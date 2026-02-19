-- TinyHouseDatabase.sql
-- Kullanıcının sağladığı DDL/DML betiği, küçük sentaks düzeltmeleri yapıldı.

IF DB_ID(N'TinyHouseDatabase') IS NULL
BEGIN
    CREATE DATABASE TinyHouseDatabase;
END
GO

USE TinyHouseDatabase;
GO

CREATE TABLE tblKullanici(
    kullaniciId INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    TelNo NVARCHAR(12),
    Mail NVARCHAR(100) UNIQUE,
    Sifre NVARCHAR(50),
    Rol NVARCHAR(10),
    aktif BIT
);
GO

CREATE TABLE tblİlan(
    ilanId INT PRIMARY KEY IDENTITY(1,1),
    kullaniciId INT,
    il NVARCHAR(20),
    fiyat SMALLINT,
    aciklama NVARCHAR(MAX),
    ilanBaslik NVARCHAR(100),
    CONSTRAINT FK_tblİlan_Kullanici FOREIGN KEY (kullaniciId) REFERENCES tblKullanici(kullaniciId)
);
GO

CREATE TABLE tblOdeme (
    odemeId INT PRIMARY KEY IDENTITY(1,1),
    odemeDurum BIT,
    odemeTur NVARCHAR(10)
);
GO

CREATE TABLE tblRezervasyon (
    rezId INT PRIMARY KEY IDENTITY(1,1),
    ilanId INT,
    kullaniciId INT,
    odemeId INT,
    toplamTutar MONEY NULL,
    basTarih DATETIME,
    bitTarih DATETIME,
    CONSTRAINT FK_tblRezervasyon_Kullanici FOREIGN KEY (kullaniciId) REFERENCES tblKullanici(kullaniciId),
    CONSTRAINT FK_tblRezervasyon_İlan FOREIGN KEY (ilanId) REFERENCES tblİlan(ilanId),
    CONSTRAINT FK_tblRezervasyon_Odeme FOREIGN KEY (odemeId) REFERENCES tblOdeme(odemeId)
);
GO

CREATE TABLE tblYorum(
    yorumId INT PRIMARY KEY IDENTITY(1,1),
    ilanId INT,
    kullaniciId INT,
    yorum NVARCHAR(MAX),
    puan DECIMAL(10,2) CHECK (puan BETWEEN 1 AND 5),
    CONSTRAINT FK_tblYorum_Kullanici FOREIGN KEY (kullaniciId) REFERENCES tblKullanici(kullaniciId),
    CONSTRAINT FK_tblYorum_İlan FOREIGN KEY (ilanId) REFERENCES tblİlan(ilanId)
);
GO

CREATE TABLE tblResim (
    ResimID INT IDENTITY(1,1) PRIMARY KEY,
    IlanID INT,
    resimData NVARCHAR(MAX),
    CONSTRAINT FK_tblResim_İlan FOREIGN KEY (IlanID) REFERENCES tblİlan(ilanId)
);
GO

CREATE TRIGGER trg_ToplamTutarHesapla
ON tblRezervasyon
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE r
    SET toplamTutar = i.fiyat * DATEDIFF(DAY, r.basTarih, r.bitTarih)
    FROM tblRezervasyon r
    INNER JOIN inserted ins ON r.rezId = ins.rezId
    INNER JOIN tblİlan i ON r.ilanId = i.ilanId;
END;
GO

-- Örnek veri ekleme
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Ahmet', 'Yılmaz', '05074748935', 'ahmetk8179@gmail.com', '123456789', 'admin', 1);
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Mustafa', 'Eroglu', '05088524645', 'mustafae@gmail.com', '987654321', 'kiracı', 1);
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Berat', 'Demirel', '05078720606', 'beratdemirel@gmail.com', '1234', 'evshaibi', 1);
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Abdullah', 'Durgun', '05075641234', 'apodurgun@gmail.com', '433580', 'admin', 1);
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Tolunay', 'Tutgün', '05528369596', 'tugtolun@gmail.com', '354186', 'kiracı', 1);
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Murat', 'Kuru', '05541230477', 'muratkuru34@gmail.com', '343434', 'evsahibi', 1);
INSERT INTO tblKullanici (Ad, Soyad, TelNo, Mail, Sifre, Rol, aktif)
VALUES ('Arda', 'Güler', '05145648963', 'ardagüler1907@gmail.com', '190719', 'kiracı', 1);
GO

INSERT INTO tblİlan (kullaniciId, il, fiyat, aciklama, ilanBaslik)
VALUES (3, 'İzmir', 12000, N'1. Sınıf malzemelerle üretilmiş O2 belgeli
Geniş Çift Loft Katlı
15mt uzunluğunda 3+1
Pimapen marka pvc sineklikli doğramalar
Plise perdeli
Uydu çanak anten hattı mevcuttur.
9mt x 3.25 mt 1. Sınıf İroko ağacından veranda
9mt otomatik açılır kapanır aydınlatmalı pergola
150 lt termisfon
Jakuzi
Yatak odasında baza başlık yatak full eşyalı olarak teslim edilecektir.', N'Urla / Kuşçular Mh.Tiny House');

INSERT INTO tblİlan (kullaniciId, il, fiyat, aciklama, ilanBaslik)
VALUES (6, 'Kocaeli', 10000, N'Tek katlı süper geniş 5mt uzunluğunda 1+1
Uydu çanak anten hattı mevcuttur.
60 termisfon
Büyük boy buzdolabı
Çamaşır makinesi
Bulaşık makinesi
Fırın
Full eşyalı teslim edilecek.', N'2 Kişilik Tiny House');
GO

INSERT INTO tblOdeme (odemeDurum, odemeTur)
VALUES (1, 'Kart');
INSERT INTO tblOdeme (odemeDurum, odemeTur)
VALUES (0, 'Nakit');
GO

INSERT INTO tblRezervasyon (ilanId, kullaniciId, odemeId, basTarih, bitTarih)
VALUES (1, 2, 1, '2025-06-01', '2025-06-05');
INSERT INTO tblRezervasyon (ilanId, kullaniciId, odemeId, basTarih, bitTarih)
VALUES (2, 5, 2, '2025-07-20', '2025-07-27');
GO

INSERT INTO tblYorum (ilanId, kullaniciId, yorum, puan)
VALUES (1, 2, N'Harika bir deneyimdi.', 5);
INSERT INTO tblYorum (ilanId, kullaniciId, yorum, puan)
VALUES (2, 5, N'Açıklamada bahsedilen çoğu şey bozuk ya da eksikti. çok kötüydü pişmanım. önermiyorum.', 1);
GO

CREATE PROCEDURE sp_İlanPuanOrtalamasi
    @ilanId INT
AS
BEGIN
    SELECT 
        i.ilanId,
        i.ilanBaslik,
        COUNT(y.yorumId) AS YorumSayisi,
        CAST(ISNULL(AVG(y.puan), 0) AS DECIMAL(4,2)) AS OrtalamaPuan
    FROM tblİlan i
    LEFT JOIN tblYorum y ON i.ilanId = y.ilanId
    WHERE i.ilanId = @ilanId
    GROUP BY i.ilanId, i.ilanBaslik;
END;
GO

CREATE PROCEDURE sp_AktiflikGuncelle
    @kullaniciId INT,
    @aktif BIT
AS
BEGIN
    UPDATE tblKullanici
    SET aktif = @aktif
    WHERE kullaniciId = @kullaniciId;
END;
GO

CREATE FUNCTION fn_İlanAralıgı
(
    @minFiyat INT = NULL,
    @maxFiyat INT = NULL
)
RETURNS TABLE
AS
RETURN
(
    SELECT ilanId, ilanBaslik, fiyat, aciklama
    FROM tblİlan
    WHERE
        (@minFiyat IS NULL OR fiyat >= @minFiyat) AND
        (@maxFiyat IS NULL OR fiyat <= @maxFiyat)
);
GO

CREATE FUNCTION fn_KacGunKalacak
(
    @kullaniciId INT
)
RETURNS INT
AS
BEGIN
    DECLARE @toplamGun INT;

    SELECT @toplamGun = ISNULL(SUM(DATEDIFF(DAY, basTarih, bitTarih)), 0)
    FROM tblRezervasyon
    WHERE kullaniciId = @kullaniciId;

    RETURN @toplamGun;
END;
GO

CREATE TRIGGER trg_FazlaYorumEngelle
ON tblYorum
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM tblYorum y
        JOIN inserted i ON y.kullaniciId = i.kullaniciId AND y.ilanId = i.ilanId
    )
    BEGIN
        RAISERROR('Aynı ilana ikinci bir yorum yapılamaz.', 16, 1);
    END
    ELSE
    BEGIN
        INSERT INTO tblYorum (ilanId, kullaniciId, yorum, puan)
        SELECT ilanId, kullaniciId, yorum, puan FROM inserted;
    END
END;
GO
