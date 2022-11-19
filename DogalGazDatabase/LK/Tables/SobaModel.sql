CREATE TABLE [LK].[SobaModel] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [SobaMarkaID] INT           NOT NULL,
    [Name]        NVARCHAR (10) NULL,
    [Tutar]       INT           NULL,
    [IsDeleted]   BIT           NULL,
    [CreateUser]  INT           NULL,
    [CreateTime]  DATETIME      NULL,
    [UpdateUser]  INT           NULL,
    [UpdateTime]  DATETIME      NULL,
    CONSTRAINT [PK_SobaModel] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_SobaModel_SobaMarka] FOREIGN KEY ([SobaMarkaID]) REFERENCES [LK].[SobaMarka] ([ID])
);

