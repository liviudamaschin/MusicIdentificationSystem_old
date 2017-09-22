using System;
using SoundFingerprinting;
using SoundFingerprinting.Audio;
using SoundFingerprinting.Audio.NAudio;
using SoundFingerprinting.Builder;
using SoundFingerprinting.DAO.Data;
using SoundFingerprinting.Query;
using SoundFingerprinting.SQL;

namespace MusicIdentification.Core
{
    public class Fingerprint
    {
        //private readonly IModelService modelService = new InMemoryModelService(); // store fingerprints in RAM
        private readonly IModelService modelService = new SqlModelService(); // store fingerprints in SQL Server Database
        private readonly IAudioService audioService = new NAudioService(); // use NAudio audio processing library
        private readonly IFingerprintCommandBuilder fingerprintCommandBuilder = new FingerprintCommandBuilder();
        private readonly IQueryCommandBuilder queryCommandBuilder = new QueryCommandBuilder();

        public bool StoreAudioFileFingerprintsInStorageForLaterRetrieval(string pathToAudioFile)
        {
            try
            {
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

                //TrackList.Add(new ListItem(isrc, string.Format("{0} - {1} - {2}", isrc, artist, title)));
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
