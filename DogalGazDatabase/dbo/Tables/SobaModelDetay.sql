CREATE TABLE [dbo].[SobaModelDetay] (
    [ID]          INT      IDENTITY (1, 1) NOT NULL,
    [TeklifID]    INT      NOT NULL,
    [SobaModelID] INT      NULL,
    [SobaMarkaID] INT      NULL,
    [Tutar]       INT      NULL,
    [IsDeleted]   BIT      NULL,
    [CreateUser]  INT      NULL,
    [CreateTime]  DATETIME NULL,
    [UpdateUser]  INT      NULL,
    [UpdateTime]  DATETIME NULL,
    CONSTRAINT [PK_SobaModelDetay] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_SobaModelDetay_Teklifler] FOREIGN KEY ([TeklifID]) REFERENCES [dbo].[Teklif] ([ID])
);





