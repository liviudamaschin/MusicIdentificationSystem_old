// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MusicIdentificationSystem.EF.Context
{
    using MusicIdentificationSystem.EF.Entities;
    using MusicIdentificationSystem.EF.Interfaces;
    using MusicIdentificationSystem.EF.Mappings;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public partial class FakeDb : IDb
    {
        public System.Data.Entity.DbSet<FingerprintEntity> Fingerprints { get; set; }
        public System.Data.Entity.DbSet<StreamStationEntity> StreamStations { get; set; }
        public System.Data.Entity.DbSet<SubFingerprintEntity> SubFingerprints { get; set; }
        public System.Data.Entity.DbSet<TrackEntity> Tracks { get; set; }

        public FakeDb()
        {
            Fingerprints = new FakeDbSet<FingerprintEntity>("Id");
            StreamStations = new FakeDbSet<StreamStationEntity>("Id");
            SubFingerprints = new FakeDbSet<SubFingerprintEntity>("Id");
            Tracks = new FakeDbSet<TrackEntity>("Id");

            InitializePartial();
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public int SpDeleteTrack(int? id)
        {

            return 0;
        }

        public System.Collections.Generic.List<SpInsertFingerprintReturnModel> SpInsertFingerprint(byte[] signature, int? trackId)
        {
            int procResult;
            return SpInsertFingerprint(signature, trackId, out procResult);
        }

        public System.Collections.Generic.List<SpInsertFingerprintReturnModel> SpInsertFingerprint(byte[] signature, int? trackId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpInsertFingerprintReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpInsertFingerprintReturnModel>> SpInsertFingerprintAsync(byte[] signature, int? trackId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpInsertFingerprint(signature, trackId, out procResult));
        }

        public System.Collections.Generic.List<SpInsertSubFingerprintReturnModel> SpInsertSubFingerprint(int? trackId, int? sequenceNumber, double? sequenceAt, long? hashTable0, long? hashTable1, long? hashTable2, long? hashTable3, long? hashTable4, long? hashTable5, long? hashTable6, long? hashTable7, long? hashTable8, long? hashTable9, long? hashTable10, long? hashTable11, long? hashTable12, long? hashTable13, long? hashTable14, long? hashTable15, long? hashTable16, long? hashTable17, long? hashTable18, long? hashTable19, long? hashTable20, long? hashTable21, long? hashTable22, long? hashTable23, long? hashTable24, string clusters)
        {
            int procResult;
            return SpInsertSubFingerprint(trackId, sequenceNumber, sequenceAt, hashTable0, hashTable1, hashTable2, hashTable3, hashTable4, hashTable5, hashTable6, hashTable7, hashTable8, hashTable9, hashTable10, hashTable11, hashTable12, hashTable13, hashTable14, hashTable15, hashTable16, hashTable17, hashTable18, hashTable19, hashTable20, hashTable21, hashTable22, hashTable23, hashTable24, clusters, out procResult);
        }

        public System.Collections.Generic.List<SpInsertSubFingerprintReturnModel> SpInsertSubFingerprint(int? trackId, int? sequenceNumber, double? sequenceAt, long? hashTable0, long? hashTable1, long? hashTable2, long? hashTable3, long? hashTable4, long? hashTable5, long? hashTable6, long? hashTable7, long? hashTable8, long? hashTable9, long? hashTable10, long? hashTable11, long? hashTable12, long? hashTable13, long? hashTable14, long? hashTable15, long? hashTable16, long? hashTable17, long? hashTable18, long? hashTable19, long? hashTable20, long? hashTable21, long? hashTable22, long? hashTable23, long? hashTable24, string clusters, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpInsertSubFingerprintReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpInsertSubFingerprintReturnModel>> SpInsertSubFingerprintAsync(int? trackId, int? sequenceNumber, double? sequenceAt, long? hashTable0, long? hashTable1, long? hashTable2, long? hashTable3, long? hashTable4, long? hashTable5, long? hashTable6, long? hashTable7, long? hashTable8, long? hashTable9, long? hashTable10, long? hashTable11, long? hashTable12, long? hashTable13, long? hashTable14, long? hashTable15, long? hashTable16, long? hashTable17, long? hashTable18, long? hashTable19, long? hashTable20, long? hashTable21, long? hashTable22, long? hashTable23, long? hashTable24, string clusters)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpInsertSubFingerprint(trackId, sequenceNumber, sequenceAt, hashTable0, hashTable1, hashTable2, hashTable3, hashTable4, hashTable5, hashTable6, hashTable7, hashTable8, hashTable9, hashTable10, hashTable11, hashTable12, hashTable13, hashTable14, hashTable15, hashTable16, hashTable17, hashTable18, hashTable19, hashTable20, hashTable21, hashTable22, hashTable23, hashTable24, clusters, out procResult));
        }

        public System.Collections.Generic.List<SpInsertTrackReturnModel> SpInsertTrack(string isrc, string artist, string title, string album, int? releaseYear, double? length)
        {
            int procResult;
            return SpInsertTrack(isrc, artist, title, album, releaseYear, length, out procResult);
        }

        public System.Collections.Generic.List<SpInsertTrackReturnModel> SpInsertTrack(string isrc, string artist, string title, string album, int? releaseYear, double? length, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpInsertTrackReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpInsertTrackReturnModel>> SpInsertTrackAsync(string isrc, string artist, string title, string album, int? releaseYear, double? length)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpInsertTrack(isrc, artist, title, album, releaseYear, length, out procResult));
        }

        public System.Collections.Generic.List<SpReadFingerprintByTrackIdReturnModel> SpReadFingerprintByTrackId(int? trackId)
        {
            int procResult;
            return SpReadFingerprintByTrackId(trackId, out procResult);
        }

        public System.Collections.Generic.List<SpReadFingerprintByTrackIdReturnModel> SpReadFingerprintByTrackId(int? trackId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadFingerprintByTrackIdReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadFingerprintByTrackIdReturnModel>> SpReadFingerprintByTrackIdAsync(int? trackId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadFingerprintByTrackId(trackId, out procResult));
        }

        public System.Collections.Generic.List<SpReadFingerprintsByHashBinHashTableAndThresholdReturnModel> SpReadFingerprintsByHashBinHashTableAndThreshold(long? hashBin0, long? hashBin1, long? hashBin2, long? hashBin3, long? hashBin4, long? hashBin5, long? hashBin6, long? hashBin7, long? hashBin8, long? hashBin9, long? hashBin10, long? hashBin11, long? hashBin12, long? hashBin13, long? hashBin14, long? hashBin15, long? hashBin16, long? hashBin17, long? hashBin18, long? hashBin19, long? hashBin20, long? hashBin21, long? hashBin22, long? hashBin23, long? hashBin24, int? threshold)
        {
            int procResult;
            return SpReadFingerprintsByHashBinHashTableAndThreshold(hashBin0, hashBin1, hashBin2, hashBin3, hashBin4, hashBin5, hashBin6, hashBin7, hashBin8, hashBin9, hashBin10, hashBin11, hashBin12, hashBin13, hashBin14, hashBin15, hashBin16, hashBin17, hashBin18, hashBin19, hashBin20, hashBin21, hashBin22, hashBin23, hashBin24, threshold, out procResult);
        }

        public System.Collections.Generic.List<SpReadFingerprintsByHashBinHashTableAndThresholdReturnModel> SpReadFingerprintsByHashBinHashTableAndThreshold(long? hashBin0, long? hashBin1, long? hashBin2, long? hashBin3, long? hashBin4, long? hashBin5, long? hashBin6, long? hashBin7, long? hashBin8, long? hashBin9, long? hashBin10, long? hashBin11, long? hashBin12, long? hashBin13, long? hashBin14, long? hashBin15, long? hashBin16, long? hashBin17, long? hashBin18, long? hashBin19, long? hashBin20, long? hashBin21, long? hashBin22, long? hashBin23, long? hashBin24, int? threshold, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadFingerprintsByHashBinHashTableAndThresholdReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadFingerprintsByHashBinHashTableAndThresholdReturnModel>> SpReadFingerprintsByHashBinHashTableAndThresholdAsync(long? hashBin0, long? hashBin1, long? hashBin2, long? hashBin3, long? hashBin4, long? hashBin5, long? hashBin6, long? hashBin7, long? hashBin8, long? hashBin9, long? hashBin10, long? hashBin11, long? hashBin12, long? hashBin13, long? hashBin14, long? hashBin15, long? hashBin16, long? hashBin17, long? hashBin18, long? hashBin19, long? hashBin20, long? hashBin21, long? hashBin22, long? hashBin23, long? hashBin24, int? threshold)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadFingerprintsByHashBinHashTableAndThreshold(hashBin0, hashBin1, hashBin2, hashBin3, hashBin4, hashBin5, hashBin6, hashBin7, hashBin8, hashBin9, hashBin10, hashBin11, hashBin12, hashBin13, hashBin14, hashBin15, hashBin16, hashBin17, hashBin18, hashBin19, hashBin20, hashBin21, hashBin22, hashBin23, hashBin24, threshold, out procResult));
        }

        public System.Collections.Generic.List<SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClustersReturnModel> SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClusters(long? hashBin0, long? hashBin1, long? hashBin2, long? hashBin3, long? hashBin4, long? hashBin5, long? hashBin6, long? hashBin7, long? hashBin8, long? hashBin9, long? hashBin10, long? hashBin11, long? hashBin12, long? hashBin13, long? hashBin14, long? hashBin15, long? hashBin16, long? hashBin17, long? hashBin18, long? hashBin19, long? hashBin20, long? hashBin21, long? hashBin22, long? hashBin23, long? hashBin24, int? threshold, string clusters)
        {
            int procResult;
            return SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClusters(hashBin0, hashBin1, hashBin2, hashBin3, hashBin4, hashBin5, hashBin6, hashBin7, hashBin8, hashBin9, hashBin10, hashBin11, hashBin12, hashBin13, hashBin14, hashBin15, hashBin16, hashBin17, hashBin18, hashBin19, hashBin20, hashBin21, hashBin22, hashBin23, hashBin24, threshold, clusters, out procResult);
        }

        public System.Collections.Generic.List<SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClustersReturnModel> SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClusters(long? hashBin0, long? hashBin1, long? hashBin2, long? hashBin3, long? hashBin4, long? hashBin5, long? hashBin6, long? hashBin7, long? hashBin8, long? hashBin9, long? hashBin10, long? hashBin11, long? hashBin12, long? hashBin13, long? hashBin14, long? hashBin15, long? hashBin16, long? hashBin17, long? hashBin18, long? hashBin19, long? hashBin20, long? hashBin21, long? hashBin22, long? hashBin23, long? hashBin24, int? threshold, string clusters, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClustersReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClustersReturnModel>> SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClustersAsync(long? hashBin0, long? hashBin1, long? hashBin2, long? hashBin3, long? hashBin4, long? hashBin5, long? hashBin6, long? hashBin7, long? hashBin8, long? hashBin9, long? hashBin10, long? hashBin11, long? hashBin12, long? hashBin13, long? hashBin14, long? hashBin15, long? hashBin16, long? hashBin17, long? hashBin18, long? hashBin19, long? hashBin20, long? hashBin21, long? hashBin22, long? hashBin23, long? hashBin24, int? threshold, string clusters)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadSubFingerprintsByHashBinHashTableAndThresholdWithClusters(hashBin0, hashBin1, hashBin2, hashBin3, hashBin4, hashBin5, hashBin6, hashBin7, hashBin8, hashBin9, hashBin10, hashBin11, hashBin12, hashBin13, hashBin14, hashBin15, hashBin16, hashBin17, hashBin18, hashBin19, hashBin20, hashBin21, hashBin22, hashBin23, hashBin24, threshold, clusters, out procResult));
        }

        public System.Collections.Generic.List<SpReadSubFingerprintsByTrackIdReturnModel> SpReadSubFingerprintsByTrackId(int? trackId)
        {
            int procResult;
            return SpReadSubFingerprintsByTrackId(trackId, out procResult);
        }

        public System.Collections.Generic.List<SpReadSubFingerprintsByTrackIdReturnModel> SpReadSubFingerprintsByTrackId(int? trackId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadSubFingerprintsByTrackIdReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadSubFingerprintsByTrackIdReturnModel>> SpReadSubFingerprintsByTrackIdAsync(int? trackId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadSubFingerprintsByTrackId(trackId, out procResult));
        }

        public System.Collections.Generic.List<SpReadTrackByArtistAndSongNameReturnModel> SpReadTrackByArtistAndSongName(string artist, string title)
        {
            int procResult;
            return SpReadTrackByArtistAndSongName(artist, title, out procResult);
        }

        public System.Collections.Generic.List<SpReadTrackByArtistAndSongNameReturnModel> SpReadTrackByArtistAndSongName(string artist, string title, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadTrackByArtistAndSongNameReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadTrackByArtistAndSongNameReturnModel>> SpReadTrackByArtistAndSongNameAsync(string artist, string title)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadTrackByArtistAndSongName(artist, title, out procResult));
        }

        public System.Collections.Generic.List<SpReadTrackByIdReturnModel> SpReadTrackById(int? id)
        {
            int procResult;
            return SpReadTrackById(id, out procResult);
        }

        public System.Collections.Generic.List<SpReadTrackByIdReturnModel> SpReadTrackById(int? id, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadTrackByIdReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadTrackByIdReturnModel>> SpReadTrackByIdAsync(int? id)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadTrackById(id, out procResult));
        }

        public System.Collections.Generic.List<SpReadTrackIsrcReturnModel> SpReadTrackIsrc(string isrc)
        {
            int procResult;
            return SpReadTrackIsrc(isrc, out procResult);
        }

        public System.Collections.Generic.List<SpReadTrackIsrcReturnModel> SpReadTrackIsrc(string isrc, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadTrackIsrcReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadTrackIsrcReturnModel>> SpReadTrackIsrcAsync(string isrc)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadTrackIsrc(isrc, out procResult));
        }

        public System.Collections.Generic.List<SpReadTracksReturnModel> SpReadTracks()
        {
            int procResult;
            return SpReadTracks(out procResult);
        }

        public System.Collections.Generic.List<SpReadTracksReturnModel> SpReadTracks(out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpReadTracksReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpReadTracksReturnModel>> SpReadTracksAsync()
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpReadTracks(out procResult));
        }

    }
}
// </auto-generated>
