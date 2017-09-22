using SoundFingerprinting;
using SoundFingerprinting.Audio;
using SoundFingerprinting.Audio.NAudio;
using SoundFingerprinting.Builder;
using SoundFingerprinting.DAO.Data;
using SoundFingerprinting.Query;
using SoundFingerprinting.SQL;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace CreateFingerprint
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        //private readonly IModelService modelService = new InMemoryModelService(); // store fingerprints in RAM
        private readonly IModelService modelService = new SqlModelService(); // store fingerprints in SQL Server Database
        private readonly IAudioService audioService = new NAudioService(); // use NAudio audio processing library
        private readonly IFingerprintCommandBuilder fingerprintCommandBuilder = new FingerprintCommandBuilder();
        private readonly IQueryCommandBuilder queryCommandBuilder = new QueryCommandBuilder();
        public BindingList<ListItem> TrackList;

        

        //private readonly IModelService modelService2 = new SqlModelService()
        //public File OpenedFile;
        public MainForm()
        {
            InitializeComponent();

            TrackList = new BindingList<ListItem>();

            bindingSourceTracks.DataSource = TrackList;
        }

        #region Events
        private void btnCreateFingerprint_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                pictureBoxWait.Visible = true;

                StoreAudioFileFingerprintsInStorageForLaterRetrieval(openFileDialog.FileName);

                pictureBoxWait.Visible = false;
            }
        }

        private void btnMatchFingerprint_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                pictureBoxWait.Visible = true;

                GetBestMatchForSong(openFileDialog.FileName);

                pictureBoxWait.Visible = false;
            }
        }
        #endregion

        #region Utils
        public void StoreAudioFileFingerprintsInStorageForLaterRetrieval(string pathToAudioFile)
        {
            try
            {
                TrackList.Clear();
                TagLib.File file = TagLib.File.Create(pathToAudioFile);
                String title = file.Tag.Title;
                String artist = file.Tag.FirstAlbumArtist;
                String album = file.Tag.Album;
                int year = (int)file.Tag.Year;
                double length = file.Properties.Duration.TotalSeconds;
                string isrc = Guid.NewGuid().ToString();

                TrackData track = new TrackData(isrc, artist, title, album, year, length);

                // store track metadata in the datasource
                //var trackReference = modelService.InsertTrack(track);
                var trackReference = modelService.InsertTrack(track);
                // create hashed fingerprints
                var hashedFingerprints = fingerprintCommandBuilder
                                            .BuildFingerprintCommand()
                                            .From(pathToAudioFile)
                                            .UsingServices(audioService)
                                            .Hash()
                                            .Result;

                // store hashes in the database for later retrieval
                modelService.InsertHashDataForTrack(hashedFingerprints, trackReference);

                TrackList.Add(new ListItem(isrc, string.Format("{0} - {1} - {2}", isrc, artist, title)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public TrackData GetBestMatchForSong(string queryAudioFile)
        {
            try
            {
                TagLib.File file = TagLib.File.Create(queryAudioFile);
                double length = file.Properties.Duration.TotalSeconds;

                int secondsToAnalyze = (int)Math.Truncate(length) - 1; // number of seconds to analyze from query file
                //int secondsToAnalyze = 20;

                int startAtSecond = 0; // start at the begining

                //Mp3FileReader reader = new Mp3FileReader(queryAudioFile);
                //WaveFileReader reader = new WaveFileReader(queryAudioFile);
                //int secondsToAnalyze = (int)Math.Truncate(reader.TotalTime.TotalSeconds)-1;
                // query the underlying database for similar audio sub-fingerprints

                Stopwatch sw = new Stopwatch();
                sw.Start();
                TrackList.Clear();
                var queryResult = queryCommandBuilder.BuildQueryCommand()
                                                     .From(queryAudioFile, secondsToAnalyze, startAtSecond)
                                                     .UsingServices(modelService, audioService)
                                                     .Query()
                                                     .Result;
                sw.Stop();
                MessageBox.Show(String.Format("Time elapsed {0}:{1}", sw.Elapsed.TotalMinutes, sw.Elapsed.TotalSeconds));
                foreach (ResultEntry result in queryResult.ResultEntries)
                {
                    TrackList.Add(new ListItem(result.Track.ISRC, string.Format("{0} - {1} : {2}", result.Track.Artist, result.Track.Title, result.TrackMatchStartsAt)));
                }
                // MessageBox.Show(string.Format("{0} - {1} - {2}", queryResult.BestMatch.Track.ISRC, queryResult.BestMatch.Track.Artist, queryResult.BestMatch.Track.Title));


                if (queryResult.BestMatch != null && queryResult.BestMatch.Track != null)
                    return queryResult.BestMatch.Track; // successful match has been found
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Error.ManageError(ex));
                return null;
            }
        }
        #endregion
    }
}
