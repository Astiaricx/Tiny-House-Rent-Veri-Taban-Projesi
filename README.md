# THR - Turizm Hane Kiralama Yönetim Sistemi

Ev kiralama işletmeleri için kapsamlı bir yönetim sistemi. Bu masaüstü uygulaması; ev sahipleri, kiracılar ve yöneticiler için çeşitli özellikler sunar.

## 📋 Proje Özellikleri

### 👥 Kullanıcı Rolleri

- **Yönetici (Admin)**: Sistem yönetimi, kullanıcı yönetimi, tüm işlemleri kontrol etme
- **Ev Sahibi**: Kendi evlerini listeleyip yönetme, kira ödeme takibi
- **Kiracı**: Ev arama, kiralama, ödeme yapma

### ⚙️ Temel Özellikler

- ✅ Kullanıcı kaydı ve giriş sistemi
- ✅ Mail tabanlı kimlik doğrulama
- ✅ Şifre sıfırlama
- ✅ Ev ilanı yönetimi (fotoğraf desteği)
- ✅ Kiralama yönetimi
- ✅ Ödeme takibi
- ✅ Kullanıcı etkinleştirme/pasifleştirme

## 🛠️ Teknolojiler

- **Dil**: C#
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Veritabanı**: SQL Server (SQLEXPRESS)
- **Resim Formatı**: AVIF

## 📁 Proje Yapısı

```
THR/
├── Ekranlar (Forms)
│   ├── girisEkran.cs          # Giriş ekranı
│   ├── kayitEkran.cs          # Kayıt ekranı
│   ├── sifreUnutEkran.cs      # Şifre sıfırlama
│   ├── adminEkran.cs          # Admin paneli
│   ├── evSahibiEkran.cs       # Ev sahibi paneli
│   ├── kiraciEkran.cs         # Kiracı paneli
│   └── Form1.cs               # Ana form
├── Veritabanı
│   ├── THRdbDataSet*.cs       # DataSet tanımları
│   └── THRdbDataSet*.xsd      # Şema dosyaları
├── Kaynaklar
│   └── Properties/            # Uygulama kaynakları
├── Evler/                     # Ev fotoğrafları
│   ├── Ev1.avif
│   ├── Ev2.avif
│   └── ...
└── app.config                 # Yapılandırma dosyası
```

## 🚀 Başlangıç

### Gereksinimler

- Visual Studio 2017 veya üzeri
- SQL Server Express
- .NET Framework 4.7.2

### Kurulum

1. **Projeyi Açma**
   ```
   Visual Studio'da THR.sln dosyasını açın
   ```

2. **Veritabanını Ayarlama**
   - SQL Server Express'te `THRdb` adında bir veritabanı oluşturun
   - Gerekli tabloları oluşturun (tblKullanici vb.)

3. **Bağlantı Stringini Güncelleme**
   ```csharp
   // girisEkran.cs dosyasında güncelleme yapın:
   SqlConnection conn = new SqlConnection("Data Source=SUNUCU_ADI\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True");
   ```
   - `SUNUCU_ADI` yerine kendi SQL Server sunucunuzun adını yazın

> Not: Projeyi çalıştırmadan önce [THR/THR/THR/App.config](THR/THR/THR/App.config#L1) içindeki `Data Source` değerini kendi SQL Server örneğinize göre güncelleyin.

4. **Uygulamayı Çalıştırma**
   ```
   F5 tuşuna basın veya Debug > Start Debugging seçin
   ```

## 📦 Derlenmiş Dosyalar

- **Debug**: `bin/Debug/THR.exe`
- **Release**: `bin/Release/THR.exe`

## 🗄️ Veritabanı

Proje SQL Server veritabanı kullanır. Temel tablolar:
- `tblKullanici` - Kullanıcı bilgileri (Mail, Sifre, rol, aktif)
- Ev ve kiralama bilgileri için diğer tablolar

## 🖼️ Ev Fotoğrafları

Fotoğraflar `Evler/` klasöründe AVIF formatında saklanır:
- Her ev için 4 resim vardır (1 başlık görseli + 3 detay görseli)
- Adlandırma: `Ev1.avif`, `Ev1.1.avif`, `Ev1.2.avif`, `Ev1.3.avif`

## 🔐 Güvenlik Notu

⚠️ **Üretim Ortamı Uyarısı**: 
- Bağlantı stringinde hardcoded şifreler kullanmayın
- Şifreleri şifreleyin
- SQL injection'a karşı parametreli sorgular kullanın (zaten yapılıyor)
- Mail gönderimi için gerekli ayarları yapın
