CREATE TABLE [LK].[SobaMarka] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [Code]       NVARCHAR (10) NULL,
    [Name]       NCHAR (10)    NULL,
    [IsDeleted]  BIT           NULL,
    [CreateUser] INT           NULL,
    [CreateTime] DATETIME      NULL,
    [UpdateUser] INT           NULL,
    [UpdateTime] DATETIME      NULL,
    CONSTRAINT [PK_SobaMarka] PRIMARY KEY CLUSTERED ([ID] ASC)
);

