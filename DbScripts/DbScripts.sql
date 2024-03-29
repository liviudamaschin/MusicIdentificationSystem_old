/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4206)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [master]
GO
/****** Object:  Database [FingerprintsDb]    Script Date: 9/5/2017 09:23:37 ******/
CREATE DATABASE [FingerprintsDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FingerprintsDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\FingerprintsDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FingerprintsDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\FingerprintsDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FingerprintsDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FingerprintsDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FingerprintsDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FingerprintsDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FingerprintsDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FingerprintsDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FingerprintsDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [FingerprintsDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FingerprintsDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FingerprintsDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FingerprintsDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FingerprintsDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FingerprintsDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FingerprintsDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FingerprintsDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FingerprintsDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FingerprintsDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FingerprintsDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FingerprintsDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FingerprintsDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FingerprintsDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FingerprintsDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FingerprintsDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FingerprintsDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FingerprintsDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FingerprintsDb] SET  MULTI_USER 
GO
ALTER DATABASE [FingerprintsDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FingerprintsDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FingerprintsDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FingerprintsDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FingerprintsDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FingerprintsDb', N'ON'
GO
ALTER DATABASE [FingerprintsDb] SET QUERY_STORE = OFF
GO
USE [FingerprintsDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [FingerprintsDb]
GO
/****** Object:  Table [dbo].[Fingerprints]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fingerprints](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [varbinary](4096) NOT NULL,
	[TrackId] [int] NOT NULL,
 CONSTRAINT [PK_FingerprintsId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StreamStations]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StreamStations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StationName] [nvarchar](250) NULL,
	[URL] [nvarchar](max) NULL,
	[LocalPath] [nvarchar](max) NULL,
 CONSTRAINT [PK_StreamStations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubFingerprints]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubFingerprints](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TrackId] [int] NOT NULL,
	[SequenceNumber] [int] NOT NULL,
	[SequenceAt] [float] NOT NULL,
	[HashTable_0] [bigint] NOT NULL,
	[HashTable_1] [bigint] NOT NULL,
	[HashTable_2] [bigint] NOT NULL,
	[HashTable_3] [bigint] NOT NULL,
	[HashTable_4] [bigint] NOT NULL,
	[HashTable_5] [bigint] NOT NULL,
	[HashTable_6] [bigint] NOT NULL,
	[HashTable_7] [bigint] NOT NULL,
	[HashTable_8] [bigint] NOT NULL,
	[HashTable_9] [bigint] NOT NULL,
	[HashTable_10] [bigint] NOT NULL,
	[HashTable_11] [bigint] NOT NULL,
	[HashTable_12] [bigint] NOT NULL,
	[HashTable_13] [bigint] NOT NULL,
	[HashTable_14] [bigint] NOT NULL,
	[HashTable_15] [bigint] NOT NULL,
	[HashTable_16] [bigint] NOT NULL,
	[HashTable_17] [bigint] NOT NULL,
	[HashTable_18] [bigint] NOT NULL,
	[HashTable_19] [bigint] NOT NULL,
	[HashTable_20] [bigint] NOT NULL,
	[HashTable_21] [bigint] NOT NULL,
	[HashTable_22] [bigint] NOT NULL,
	[HashTable_23] [bigint] NOT NULL,
	[HashTable_24] [bigint] NOT NULL,
	[Clusters] [varchar](255) NULL,
 CONSTRAINT [PK_SubFingerprintsId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracks]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ISRC] [varchar](50) NULL,
	[Artist] [varchar](255) NULL,
	[Title] [varchar](255) NULL,
	[Album] [varchar](255) NULL,
	[ReleaseYear] [int] NULL,
	[Length] [float] NULL,
 CONSTRAINT [PK_TracksId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_TrackIdLookup]    Script Date: 9/5/2017 09:23:37 ******/
CREATE NONCLUSTERED INDEX [IX_TrackIdLookup] ON [dbo].[Fingerprints]
(
	[TrackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TrackIdLookupOnSubfingerprints]    Script Date: 9/5/2017 09:23:37 ******/
CREATE NONCLUSTERED INDEX [IX_TrackIdLookupOnSubfingerprints] ON [dbo].[SubFingerprints]
(
	[TrackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tracks] ADD  DEFAULT ((0)) FOR [ReleaseYear]
GO
ALTER TABLE [dbo].[Tracks] ADD  DEFAULT ((0)) FOR [Length]
GO
ALTER TABLE [dbo].[Fingerprints]  WITH CHECK ADD  CONSTRAINT [FK_Fingerprints_Tracks] FOREIGN KEY([TrackId])
REFERENCES [dbo].[Tracks] ([Id])
GO
ALTER TABLE [dbo].[Fingerprints] CHECK CONSTRAINT [FK_Fingerprints_Tracks]
GO
ALTER TABLE [dbo].[SubFingerprints]  WITH CHECK ADD  CONSTRAINT [FK_SubFingerprints_Tracks] FOREIGN KEY([TrackId])
REFERENCES [dbo].[Tracks] ([Id])
GO
ALTER TABLE [dbo].[SubFingerprints] CHECK CONSTRAINT [FK_SubFingerprints_Tracks]
GO
ALTER TABLE [dbo].[Tracks]  WITH CHECK ADD  CONSTRAINT [CK_ReleaseYear] CHECK  (([ReleaseYear]>(-1)))
GO
ALTER TABLE [dbo].[Tracks] CHECK CONSTRAINT [CK_ReleaseYear]
GO
ALTER TABLE [dbo].[Tracks]  WITH CHECK ADD  CONSTRAINT [CK_TracksTrackLength] CHECK  (([Length]>(-1)))
GO
ALTER TABLE [dbo].[Tracks] CHECK CONSTRAINT [CK_TracksTrackLength]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteTrack]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteTrack]
	@Id INT
AS
BEGIN
	DELETE FROM SubFingerprints WHERE SubFingerprints.TrackId = @Id
	DELETE FROM Tracks WHERE Tracks.Id = @Id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertFingerprint]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertFingerprint]
	@Signature VARBINARY(4096),
	@TrackId INT
AS
BEGIN
INSERT INTO Fingerprints (
	Signature,
	TrackId
	) OUTPUT inserted.Id
VALUES
(
	@Signature, @TrackId
);
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSubFingerprint]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertSubFingerprint]
	@TrackId INT,
	@SequenceNumber INT,
	@SequenceAt FLOAT,
	@HashTable_0 BIGINT,
    @HashTable_1 BIGINT,
    @HashTable_2 BIGINT,
    @HashTable_3 BIGINT,
    @HashTable_4 BIGINT,
    @HashTable_5 BIGINT,
    @HashTable_6 BIGINT,
    @HashTable_7 BIGINT,
    @HashTable_8 BIGINT,
    @HashTable_9 BIGINT,
    @HashTable_10 BIGINT,
    @HashTable_11 BIGINT,
    @HashTable_12 BIGINT,
    @HashTable_13 BIGINT,
    @HashTable_14 BIGINT,
    @HashTable_15 BIGINT,
    @HashTable_16 BIGINT,
    @HashTable_17 BIGINT,
    @HashTable_18 BIGINT,
    @HashTable_19 BIGINT,
    @HashTable_20 BIGINT,
    @HashTable_21 BIGINT,	
	@HashTable_22 BIGINT,	
	@HashTable_23 BIGINT,	
	@HashTable_24 BIGINT,
	@Clusters VARCHAR(255)
AS
BEGIN
INSERT INTO SubFingerprints (
	TrackId,
	SequenceNumber,
	SequenceAt,
	HashTable_0,
    HashTable_1,
    HashTable_2,
    HashTable_3,
    HashTable_4,
    HashTable_5,
    HashTable_6,
    HashTable_7,
    HashTable_8,
    HashTable_9,
    HashTable_10,
    HashTable_11,
    HashTable_12,
    HashTable_13,
    HashTable_14,
    HashTable_15,
    HashTable_16,
    HashTable_17,
    HashTable_18,
    HashTable_19,
    HashTable_20,
    HashTable_21,	
	HashTable_22,	
	HashTable_23,	
	HashTable_24,
	Clusters
	) OUTPUT inserted.Id
VALUES
(
	@TrackId, @SequenceNumber, @SequenceAt, @HashTable_0, @HashTable_1, @HashTable_2, @HashTable_3, @HashTable_4, @HashTable_5, @HashTable_6,
    @HashTable_7, @HashTable_8, @HashTable_9, @HashTable_10, @HashTable_11, @HashTable_12, @HashTable_13, @HashTable_14, @HashTable_15,
    @HashTable_16, @HashTable_17, @HashTable_18, @HashTable_19, @HashTable_20, @HashTable_21, @HashTable_22, @HashTable_23, @HashTable_24,
	@Clusters
);
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertTrack]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertTrack]
	@ISRC VARCHAR(50),
	@Artist VARCHAR(255),
	@Title VARCHAR(255),
	@Album VARCHAR(255),
	@ReleaseYear INT,
	@Length FLOAT
AS
INSERT INTO Tracks (
	ISRC,
	Artist,
	Title,
	Album,
	ReleaseYear,
	Length
	) OUTPUT inserted.Id
VALUES
(
 	@ISRC, @Artist, @Title, @Album, @ReleaseYear, @Length
);

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadFingerprintByTrackId]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadFingerprintByTrackId]
	@TrackId INT
AS
BEGIN
	SELECT * FROM Fingerprints WHERE TrackId = @TrackId
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadFingerprintsByHashBinHashTableAndThreshold]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadFingerprintsByHashBinHashTableAndThreshold]
	@HashBin_0 BIGINT, @HashBin_1 BIGINT, @HashBin_2 BIGINT, @HashBin_3 BIGINT, @HashBin_4 BIGINT, 
	@HashBin_5 BIGINT, @HashBin_6 BIGINT, @HashBin_7 BIGINT, @HashBin_8 BIGINT, @HashBin_9 BIGINT,
	@HashBin_10 BIGINT, @HashBin_11 BIGINT, @HashBin_12 BIGINT, @HashBin_13 BIGINT, @HashBin_14 BIGINT, 
	@HashBin_15 BIGINT, @HashBin_16 BIGINT, @HashBin_17 BIGINT, @HashBin_18 BIGINT, @HashBin_19 BIGINT,
	@HashBin_20 BIGINT, @HashBin_21 BIGINT, @HashBin_22 BIGINT, @HashBin_23 BIGINT, @HashBin_24 BIGINT,
	@Threshold INT
AS
SELECT * FROM SubFingerprints, 
	( SELECT Id FROM 
	   (
		SELECT Id FROM SubFingerprints WHERE HashTable_0 = @HashBin_0
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_1 = @HashBin_1
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_2 = @HashBin_2
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_3 = @HashBin_3
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_4 = @HashBin_4
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_5 = @HashBin_5
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_6 = @HashBin_6
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_7 = @HashBin_7
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_8 = @HashBin_8
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_9 = @HashBin_9
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_10 = @HashBin_10
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_11 = @HashBin_11
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_12 = @HashBin_12
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_13 = @HashBin_13
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_14 = @HashBin_14
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_15 = @HashBin_15
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_16 = @HashBin_16
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_17 = @HashBin_17
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_18 = @HashBin_18
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_19 = @HashBin_19
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_20 = @HashBin_20
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_21 = @HashBin_21
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_22 = @HashBin_22
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_23 = @HashBin_23
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_24 = @HashBin_24
	  ) AS Hashes
	 GROUP BY Hashes.Id
	 HAVING COUNT(Hashes.Id) >= @Threshold
	) AS Thresholded
WHERE SubFingerprints.Id = Thresholded.Id	

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadSubFingerprintsByHashBinHashTableAndThresholdWithClusters]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadSubFingerprintsByHashBinHashTableAndThresholdWithClusters]
@HashBin_0 BIGINT, @HashBin_1 BIGINT, @HashBin_2 BIGINT, @HashBin_3 BIGINT, @HashBin_4 BIGINT, 
	@HashBin_5 BIGINT, @HashBin_6 BIGINT, @HashBin_7 BIGINT, @HashBin_8 BIGINT, @HashBin_9 BIGINT,
	@HashBin_10 BIGINT, @HashBin_11 BIGINT, @HashBin_12 BIGINT, @HashBin_13 BIGINT, @HashBin_14 BIGINT, 
	@HashBin_15 BIGINT, @HashBin_16 BIGINT, @HashBin_17 BIGINT, @HashBin_18 BIGINT, @HashBin_19 BIGINT,
	@HashBin_20 BIGINT, @HashBin_21 BIGINT, @HashBin_22 BIGINT, @HashBin_23 BIGINT, @HashBin_24 BIGINT,
	@Threshold INT, @Clusters VARCHAR(255)
AS
SELECT * FROM SubFingerprints, 
	( SELECT Id FROM 
	   (
		SELECT Id FROM SubFingerprints WHERE HashTable_0 = @HashBin_0
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_1 = @HashBin_1
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_2 = @HashBin_2
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_3 = @HashBin_3
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_4 = @HashBin_4
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_5 = @HashBin_5
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_6 = @HashBin_6
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_7 = @HashBin_7
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_8 = @HashBin_8
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_9 = @HashBin_9
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_10 = @HashBin_10
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_11 = @HashBin_11
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_12 = @HashBin_12
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_13 = @HashBin_13
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_14 = @HashBin_14
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_15 = @HashBin_15
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_16 = @HashBin_16
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_17 = @HashBin_17
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_18 = @HashBin_18
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_19 = @HashBin_19
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_20 = @HashBin_20
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_21 = @HashBin_21
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_22 = @HashBin_22
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_23 = @HashBin_23
		UNION ALL
		SELECT Id FROM SubFingerprints WHERE HashTable_24 = @HashBin_24
	  ) AS Hashes
	 GROUP BY Hashes.Id
	 HAVING COUNT(Hashes.Id) >= @Threshold
	) AS Thresholded
WHERE SubFingerprints.Id = Thresholded.Id AND SubFingerprints.Clusters LIKE @Clusters

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadSubFingerprintsByTrackId]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadSubFingerprintsByTrackId]
	@TrackId INT
AS
BEGIN
   SELECT * FROM SubFingerprints WHERE SubFingerprints.TrackId = @TrackId
END					 
-- READ TRACK BY ARTIST NAME AND SONG NAME
IF OBJECT_ID('sp_ReadTrackByArtistAndSongName','P') IS NOT NULL
	DROP PROCEDURE sp_ReadTrackByArtistAndSongName

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadTrackByArtistAndSongName]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadTrackByArtistAndSongName]
	@Artist VARCHAR(255),
	@Title VARCHAR(255) 
AS
SELECT * FROM Tracks WHERE Tracks.Title = @Title AND Tracks.Artist = @Artist

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadTrackById]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadTrackById]
	@Id INT
AS
SELECT * FROM Tracks WHERE Tracks.Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadTrackISRC]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadTrackISRC]
	@ISRC VARCHAR(50)
AS
SELECT * FROM Tracks WHERE Tracks.ISRC = @ISRC

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadTracks]    Script Date: 9/5/2017 09:23:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReadTracks]
AS
SELECT * FROM Tracks

GO
USE [master]
GO
ALTER DATABASE [FingerprintsDb] SET  READ_WRITE 
GO
