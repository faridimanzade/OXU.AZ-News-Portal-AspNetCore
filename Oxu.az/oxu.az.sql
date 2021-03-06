USE [OxuAZ]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28/12/2020 15:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 28/12/2020 15:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PostDate] [nvarchar](max) NOT NULL,
	[PostTime] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](400) NOT NULL,
	[LikeAmount] [int] NULL,
	[DislikeAmount] [int] NULL,
	[VisitedAmount] [int] NULL,
	[FileName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200804184816_createDB', N'3.1.6')
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (1, N'August 04', N'22:56', N'Xüsusi karantin rejiminin sərtləşdirildiyi ərazilərə xidməti zərurətlə əlaqədar kimlər gedə bilər? - SİYAHI', 0, 0, 0, N'POST150b677da-3b34-40c4-b9e7-60673e44213d.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (2, N'August 04', N'22:58', N'Beyrutdakı partlayışda 10 nəfər ölüb, yüzlərlə yaralı var – YENİLƏNİB+FOTO/VİDEO', 0, 0, 0, N'bigBang9d614e14-6bbf-4216-af64-14060765d68b.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (3, N'August 04', N'22:58', N'Bakının mərkəzindən ətraf qəsəbələr də daxil olmaqla, beş ekspres xətt təşkil olunacaq', 0, 0, 0, N'ekspres_avtobusf55d4480-5c48-46c8-ad84-16029b3b719d.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (4, N'August 04', N'22:59', N'AZAL Çinin aparıcı həkimlərini Bakıya çatdırdı', 0, 0, 0, N'AZAL_China_2aaa9b9ad-a648-4f60-890d-b0f3a8912d6f.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (5, N'August 04', N'23:00', N'DSMF-nin gəlir və xərcləri azaldılacaq', 2, 0, 0, N'moneyMan940e60b0-6e10-4cb4-8fad-7f7b7b233f91.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (6, N'August 04', N'23:01', N'“Bacarıqlı gənclər” festivalı keçiriləcək', 0, 1, 0, N'bacariqliGencler1f2cc283c-50e1-4842-a08f-d7d079b57265.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (7, N'August 04', N'23:01', N'Azaldılan elm xərclərindən ən çox pay Elmlər Akademiyasına düşür', 2, 0, 1, N'calculatordadffe08-afeb-43f3-be40-22f63780f6f9.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (9, N'August 06', N'00:10', N'Qlobal istiləşmə 23 milyon nəfərə təsir edəcək - VİDEO', 2, 2, 1, N'İSTİ506df959-a822-4eed-9abd-842b378c0f92.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (11, N'August 06', N'00:32', N'“Başakşəhər” Avroliqa ilə vidalaşdı, “Şaxtyor”dan möhtəşəm oyun', 3, 1, 2, N'football19090a74-63d3-4119-aae9-9c4c6c0bca87.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (12, N'August 06', N'00:32', N'Düşmən informasiya cəbhəsində də layiqli cavabını alır - VİDEO', 1, 1, 2, N'KAR18d3d564-875b-4bcc-a611-c4dc53b2e48b.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (14, N'August 06', N'01:29', N'“TRT Arabic” Tovuz istiqamətindəki erməni təxribatı ilə bağlı reportaj hazırladı - VİDEO', 6, 1, 2, N'terror164397d0-7ab7-4fc2-bd78-9ae0c027f1b8.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (15, N'August 06', N'02:45', N'ABŞ-dan seçkilərə müdaxilə edənlərlə bağlı xəbər verənlərə ağlasığmaz mükafat', 6, 4, 2, N'dollarsbca3bd69-187c-4efd-8d80-2137f4e59ce6.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (16, N'August 06', N'02:48', N'Bakıda yaşayış binasında yanğın: Zəhərlənən var', 32, 7, 15, N'fireFighter57423c54-a0b3-47bd-b105-5cdf09353bac.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (19, N'August 10', N'00:11', N'İsraildə Azərbaycan Silahlı Qüvvələrinə dəstək məqsədi ilə yürüş-mitinq keçirilib - YENİLƏNİB', 4, 2, 4, N'bayraqf791ff87-8ffc-4978-8bab-d19cf83032fa.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (20, N'August 10', N'01:22', N'Avropa Liqasında püşk həyəcanı: “Neftçi”, “Keşlə” və “Sumqayıt” rəqiblərini gözləyir', 3, 2, 3, N'AVROLİQA664677a2-d371-40a3-9701-63553090557f.jpg')
INSERT [dbo].[News] ([id], [PostDate], [PostTime], [Title], [LikeAmount], [DislikeAmount], [VisitedAmount], [FileName]) VALUES (21, N'August 11', N'22:16', N'Belarusda iki mindən çox insan saxlanılıb', 6, 1, 2, N'protest34b4b7f0-f7a1-4fb1-ad1f-21f3eec9961d.jpg')
SET IDENTITY_INSERT [dbo].[News] OFF
GO
