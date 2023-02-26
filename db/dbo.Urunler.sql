CREATE TABLE [dbo].[Urunler] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [UrunAdi]        NVARCHAR (30)  NULL,
    [UrunAciklamasi] NVARCHAR (150) NULL,
    [UrunFiyati]     MONEY          NULL,
    [KullaniciId]    INT            NULL,
    [Adet]           INT            NULL,
    [Satildi]        BIT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

