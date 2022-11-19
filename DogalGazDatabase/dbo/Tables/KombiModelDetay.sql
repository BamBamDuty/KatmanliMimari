CREATE TABLE [dbo].[KombiModelDetay] (
    [ID]           INT      IDENTITY (1, 1) NOT NULL,
    [TeklifID]     INT      NOT NULL,
    [KombiModelID] INT      NULL,
    [KombiMarkaID] INT      NULL,
    [Tutar]        INT      NULL,
    [IsDeleted]    BIT      NULL,
    [CreateUser]   INT      NULL,
    [CreateTime]   DATETIME NULL,
    [UpdateUser]   INT      NULL,
    [UpdateTime]   DATETIME NULL,
    CONSTRAINT [PK_KombiModelDetay] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_KombiModelDetay_KombiMarka] FOREIGN KEY ([KombiMarkaID]) REFERENCES [LK].[KombiMarka] ([ID]),
    CONSTRAINT [FK_KombiModelDetay_KombiModel] FOREIGN KEY ([KombiModelID]) REFERENCES [LK].[KombiModel] ([ID]),
    CONSTRAINT [FK_KombiModelDetay_Teklifler] FOREIGN KEY ([TeklifID]) REFERENCES [dbo].[Teklif] ([ID])
);







