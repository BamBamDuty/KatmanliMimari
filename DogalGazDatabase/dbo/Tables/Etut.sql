CREATE TABLE [dbo].[Etut] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [AdSoyad]    NVARCHAR (50) NULL,
    [Telefon]    NVARCHAR (50) NULL,
    [Adres]      NVARCHAR (50) NULL,
    [EtutTarihi] DATETIME      NULL,
    [IsDeleted]  BIT           NULL,
    [CreateUser] INT           NULL,
    [CreateTime] DATETIME      NULL,
    [UpdateUser] INT           NULL,
    [UpdateTime] DATETIME      NULL,
    CONSTRAINT [PK_Etut] PRIMARY KEY CLUSTERED ([ID] ASC)
);





