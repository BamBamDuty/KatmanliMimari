CREATE TABLE [dbo].[Teklif] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [AdSoyad]       NVARCHAR (50)  NULL,
    [TeklifTarihi]  DATETIME       NULL,
    [Telefon]       INT            NULL,
    [Adres]         NVARCHAR (500) NULL,
    [Tutar]         INT            NULL,
    [Iskonto]       INT            NULL,
    [OdenecekTutar] INT            NULL,
    [TeklifDurum]   INT            NULL,
    [IsDeleted]     BIT            NULL,
    [CreateUser]    INT            NULL,
    [CreateTime]    DATETIME       NULL,
    [UpdateUser]    INT            NULL,
    [UpdateTime]    DATETIME       NULL,
    CONSTRAINT [PK_Teklif] PRIMARY KEY CLUSTERED ([ID] ASC)
);



