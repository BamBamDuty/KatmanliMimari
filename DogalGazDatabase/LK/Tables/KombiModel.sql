CREATE TABLE [LK].[KombiModel] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [KombiMarkaID] INT           NOT NULL,
    [Name]         NVARCHAR (50) NULL,
    [Tutar]        INT           NULL,
    [IsDeleted]    BIT           NULL,
    [CreateUser]   INT           NULL,
    [CreateTime]   DATETIME      NULL,
    [UpdateUser]   INT           NULL,
    [UpdateTime]   DATETIME      NULL,
    CONSTRAINT [PK_KombiModel] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_KombiModel_KombiMarka] FOREIGN KEY ([KombiMarkaID]) REFERENCES [LK].[KombiMarka] ([ID])
);

