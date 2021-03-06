USE [master]
GO
/****** Object:  Database [Quiz]    Script Date: 14.05.2022 22:17:54 ******/
CREATE DATABASE [Quiz]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Qu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Qu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Qu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Qu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Quiz] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quiz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quiz] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quiz] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quiz] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quiz] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quiz] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quiz] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quiz] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quiz] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quiz] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quiz] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quiz] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quiz] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quiz] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quiz] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quiz] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quiz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quiz] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quiz] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quiz] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quiz] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quiz] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quiz] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quiz] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quiz] SET  MULTI_USER 
GO
ALTER DATABASE [Quiz] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quiz] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quiz] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quiz] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quiz] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quiz] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Quiz] SET QUERY_STORE = OFF
GO
USE [Quiz]
GO
/****** Object:  Table [dbo].[Table_Sonuc]    Script Date: 14.05.2022 22:17:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Sonuc](
	[SinavTarihi] [smalldatetime] NOT NULL,
	[DogruSayisi] [tinyint] NOT NULL,
	[YanlisSayisi] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Konu]    Script Date: 14.05.2022 22:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Konu](
	[KonuAdi] [nvarchar](50) NOT NULL,
	[KonuID] [tinyint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_Konu] PRIMARY KEY CLUSTERED 
(
	[KonuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Kullanici]    Script Date: 14.05.2022 22:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Kullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](25) NOT NULL,
	[Ad] [nvarchar](25) NOT NULL,
	[Soyad] [nvarchar](25) NOT NULL,
	[Sifre] [nvarchar](25) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[KullaniciTipiID] [tinyint] NOT NULL,
 CONSTRAINT [PK_Tbl_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_KullaniciTipi]    Script Date: 14.05.2022 22:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_KullaniciTipi](
	[KullaniciTipiID] [tinyint] NOT NULL,
	[KullaniciTipiAdi] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Tbl_KullaniciTipi] PRIMARY KEY CLUSTERED 
(
	[KullaniciTipiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Sorular]    Script Date: 14.05.2022 22:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Sorular](
	[SoruID] [int] IDENTITY(1,1) NOT NULL,
	[Soru] [text] NOT NULL,
	[Yanlis1] [nvarchar](50) NOT NULL,
	[Yanlis2] [nvarchar](50) NOT NULL,
	[Yanlis3] [nvarchar](50) NOT NULL,
	[Dogru] [nvarchar](50) NOT NULL,
	[UniteID] [tinyint] NOT NULL,
	[SoruResimYolu] [image] NULL,
	[KonuID] [tinyint] NOT NULL,
 CONSTRAINT [PK_tbl_Sorular] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_unite]    Script Date: 14.05.2022 22:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_unite](
	[UniteID] [tinyint] NOT NULL,
	[UniteAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_unite] PRIMARY KEY CLUSTERED 
(
	[UniteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Konu] ON 

INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Mevsimlerin Oluşumu', 1)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'İklim ve Hava Hareketleri', 2)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'DNA ve Genetik Kod', 3)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Kalıtım', 4)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Mutasyon ve Modifikasyon', 5)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Adaptasyon', 6)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Biyoteknoloji', 7)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Basınç', 8)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Periyotik Sistem', 9)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Fiziksel ve Kimyasal Değişimler', 10)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Asitler ve Bazlar', 12)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Maddenin Isı ve Etkilişimi', 13)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Türkiye''de Kimya Endistrisi', 14)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Basit Makineler', 15)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Enerji Dönüşümleri', 16)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Madde Döngüleri ve Çevre Sorunları', 17)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Sürdürülebilir Kalkınma', 18)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Elektrik Yükleri ve Elektriklenme', 19)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Elektrik Yüklü Cisimler', 20)
INSERT [dbo].[tbl_Konu] ([KonuAdi], [KonuID]) VALUES (N'Elektrik Enerjisinin Dönüşümü', 21)
SET IDENTITY_INSERT [dbo].[tbl_Konu] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Kullanici] ON 

INSERT [dbo].[Tbl_Kullanici] ([KullaniciID], [KullaniciAdi], [Ad], [Soyad], [Sifre], [Email], [KullaniciTipiID]) VALUES (1, N'kasimtt', N'kasım islam', N'tatlı', N'qazwer25', N'kasimislamtatli@gmail.com', 1)
INSERT [dbo].[Tbl_Kullanici] ([KullaniciID], [KullaniciAdi], [Ad], [Soyad], [Sifre], [Email], [KullaniciTipiID]) VALUES (2, N'ismailhd', N'ismail hakkı', N'Dur', N'1099', N'ismailhakki@gmail.com', 1)
INSERT [dbo].[Tbl_Kullanici] ([KullaniciID], [KullaniciAdi], [Ad], [Soyad], [Sifre], [Email], [KullaniciTipiID]) VALUES (4, N'ibrahimtt', N'ibrahim Ethem', N'tatlı', N'454545', N'ibrahimtt@gmail.com', 3)
INSERT [dbo].[Tbl_Kullanici] ([KullaniciID], [KullaniciAdi], [Ad], [Soyad], [Sifre], [Email], [KullaniciTipiID]) VALUES (9, N'GülsümHoca', N'Ümmügülsüm', N'tatlı', N'1998', N'Ümmügülsümtatli@hotmail.com', 2)
INSERT [dbo].[Tbl_Kullanici] ([KullaniciID], [KullaniciAdi], [Ad], [Soyad], [Sifre], [Email], [KullaniciTipiID]) VALUES (10, N'alparslan13', N'alparslan', N'aydoğan', N'sikik', N'alparslanaydogan@hotetmail.com', 2)
INSERT [dbo].[Tbl_Kullanici] ([KullaniciID], [KullaniciAdi], [Ad], [Soyad], [Sifre], [Email], [KullaniciTipiID]) VALUES (11, N'sikik12', N'alp', N'sikiktaş', N'12345', N'yok', 3)
SET IDENTITY_INSERT [dbo].[Tbl_Kullanici] OFF
GO
INSERT [dbo].[Tbl_KullaniciTipi] ([KullaniciTipiID], [KullaniciTipiAdi]) VALUES (1, N'Admin')
INSERT [dbo].[Tbl_KullaniciTipi] ([KullaniciTipiID], [KullaniciTipiAdi]) VALUES (2, N'Sınav Sorumlusu')
INSERT [dbo].[Tbl_KullaniciTipi] ([KullaniciTipiID], [KullaniciTipiAdi]) VALUES (3, N'Öğrenci')
GO
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (1, N'Mevsimler ve İklim')
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (2, N'DNA ve Genetik Kod')
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (3, N'Basınç')
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (4, N'Madde ve Endüstri')
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (5, N'Basit Makineler')
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (6, N'Enerji Dönüşümleri ve Çevre Bilimi')
INSERT [dbo].[tbl_unite] ([UniteID], [UniteAdi]) VALUES (7, N'Elektrik Yükleri ve Elektrik Enerjisi')
GO
ALTER TABLE [dbo].[Tbl_Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Kullanici_Tbl_KullaniciTipi] FOREIGN KEY([KullaniciTipiID])
REFERENCES [dbo].[Tbl_KullaniciTipi] ([KullaniciTipiID])
GO
ALTER TABLE [dbo].[Tbl_Kullanici] CHECK CONSTRAINT [FK_Tbl_Kullanici_Tbl_KullaniciTipi]
GO
ALTER TABLE [dbo].[tbl_Sorular]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sorular_tbl_Konu] FOREIGN KEY([KonuID])
REFERENCES [dbo].[tbl_Konu] ([KonuID])
GO
ALTER TABLE [dbo].[tbl_Sorular] CHECK CONSTRAINT [FK_tbl_Sorular_tbl_Konu]
GO
ALTER TABLE [dbo].[tbl_Sorular]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sorular_tbl_unite] FOREIGN KEY([UniteID])
REFERENCES [dbo].[tbl_unite] ([UniteID])
GO
ALTER TABLE [dbo].[tbl_Sorular] CHECK CONSTRAINT [FK_tbl_Sorular_tbl_unite]
GO
USE [master]
GO
ALTER DATABASE [Quiz] SET  READ_WRITE 
GO
