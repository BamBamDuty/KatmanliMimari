CREATE TABLE [dbo].[DigerDetay] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [TeklifID]   INT           NOT NULL,
    [DigerID]    INT           NULL,
    [Code]       NVARCHAR (20) NULL,
    [Name]       NVARCHAR (20) NULL,
    [Tutar]      INT           NULL,
    [IsDeleted]  BIT           NULL,
    [CreateUser] INT           NULL,
    [CreateTime] DATETIME      NULL,
    [UpdateUser] INT           NULL,
    [UpdateTime] DATETIME      NULL,
    CONSTRAINT [PK_DigerDetay] PRIMARY KEY CLUSTERED ([ID] ASC)
);



