CREATE TABLE [dbo].[OdemeBilgileri] (
    [ID]              INT           IDENTITY (1, 1) NOT NULL,
    [TeklifID]        INT           NULL,
    [Aciklama]        NVARCHAR (50) NULL,
    [KrediKartiTutar] INT           NULL,
    [NakitTutar]      INT           NULL,
    [IsDeleted]       BIT           NULL,
    [CreateUser]      INT           NULL,
    [CreateTime]      DATETIME      NULL,
    [UpdateUser]      INT           NULL,
    [UpdateTime]      DATETIME      NULL,
    CONSTRAINT [PK_OdemeBilgileri] PRIMARY KEY CLUSTERED ([ID] ASC)
);





