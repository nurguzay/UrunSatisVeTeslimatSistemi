CREATE TABLE [dbo].[Kullanici] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [AdiSoyadi]   NVARCHAR (20)  NULL,
    [DogumTarihi] DATETIME       NULL,
    [Telefon]     INT            NULL,
    [Adres]       NVARCHAR (150) NULL,
    [Email]       NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
