CREATE TABLE [dbo].[Urunler] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [UrunAdi]        NVARCHAR (30)  NULL,
    [UrunAciklamasi] NVARCHAR (150) NULL,
    [UrunFiyati]     INT            NULL,
    [KullaniciId]    INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);