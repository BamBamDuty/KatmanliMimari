CREATE TABLE [dbo].[DogalGazTesisatDetay] (
    [ID]                INT      IDENTITY (1, 1) NOT NULL,
    [TeklifID]          INT      NOT NULL,
    [DogalGazTesisatID] INT      NULL,
    [Tutar]             INT      NULL,
    [IsDeleted]         BIT      NULL,
    [CreateUser]        INT      NULL,
    [CreateTime]        DATETIME NULL,
    [UpdateUser]        INT      NULL,
    [UpdateTime]        DATETIME NULL,
    CONSTRAINT [PK_DogalGazTesisatDetay] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_DogalGazTesisatDetay_Teklifler] FOREIGN KEY ([TeklifID]) REFERENCES [dbo].[Teklif] ([ID])
);



