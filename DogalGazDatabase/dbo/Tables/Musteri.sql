CREATE TABLE [dbo].[Musteri] (
    [ID]               INT           IDENTITY (1, 1) NOT NULL,
    [AdSoyad]          NVARCHAR (50) NULL,
    [MusteriSiraNo]    INT           NULL,
    [BaglantiNumarasi] NVARCHAR (50) NULL,
    [TuketimNo]        NVARCHAR (50) NULL,
    [SayacNo]          NVARCHAR (50) NULL,
    [IsDeleted]        BIT           NULL,
    CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED ([ID] ASC)
);







