CREATE TABLE [dbo].[Kullanicilar] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [KullaniciAdi]  NVARCHAR (50) NULL,
    [Sifre]         NVARCHAR (50) NULL,
    [KullaniciTipi] NVARCHAR (50) NULL,
    [IsDeleted]     BIT           NULL,
    [CreateUser]    INT           NULL,
    [CreateTime]    DATETIME      NULL,
    [UpdateUser]    INT           NULL,
    [UpdateTime]    DATETIME      NULL,
    CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED ([ID] ASC)
);





