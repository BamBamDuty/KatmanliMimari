CREATE TABLE [LK].[DogalGazTesisat] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [Code]       NVARCHAR (10) NULL,
    [Name]       NVARCHAR (50) NULL,
    [Tutar]      INT           NULL,
    [IsDeleted]  BIT           NULL,
    [CreateUser] INT           NULL,
    [CreateTime] DATETIME      NULL,
    [UpdateUser] INT           NULL,
    [UpdateTime] DATETIME      NULL,
    CONSTRAINT [PK_DogalGazTesisati] PRIMARY KEY CLUSTERED ([ID] ASC)
);

