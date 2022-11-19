CREATE TABLE [dbo].[RadyatorDetay] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [TeklifID]   INT           NOT NULL,
    [RadyatorID] INT           NULL,
    [Metre]      NVARCHAR (50) NULL,
    [Tutar]      INT           NULL,
    [IsDeleted]  BIT           NULL,
    [CreateUser] INT           NULL,
    [CreateTime] DATETIME      NULL,
    [UpdateUser] INT           NULL,
    [UpdateTime] DATETIME      NULL,
    CONSTRAINT [PK_RadyatorDetay] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_RadyatorDetay_Teklifler] FOREIGN KEY ([TeklifID]) REFERENCES [dbo].[Teklif] ([ID])
);





