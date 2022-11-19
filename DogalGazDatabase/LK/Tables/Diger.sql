CREATE TABLE [LK].[Diger] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [Code]       NVARCHAR (10) NULL,
    [Name]       NVARCHAR (20) NULL,
    [Tutar]      INT           NULL,
    [IsDeleted]  BIT           NULL,
    [CreateUser] INT           NULL,
    [CreateTime] DATETIME      NULL,
    [UpdateUser] INT           NULL,
    [UpdateTime] DATETIME      NULL,
    CONSTRAINT [PK_Diger] PRIMARY KEY CLUSTERED ([ID] ASC)
);

