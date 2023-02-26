CREATE TABLE [dbo].[Teslimat] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [AliciAdi]   NVARCHAR (20)  NOT NULL,
    [UrunAdi]    NVARCHAR (30)  NOT NULL,
    [UrunFiyati] MONEY          NOT NULL,
    [Telefon]    CHAR (11)      NOT NULL,
    [Adres]      NVARCHAR (150) NOT NULL,
    [Email]      NVARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

