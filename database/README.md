# Database scripts

Bu klasör SQL Server üzerinde çalıştırılabilecek iki temel dosya içerir:



- `TinyHouseDatabase.sql` — kullanıcı tarafından sağlanan tam DDL/DML betiği (tablolar, trigger'lar, prosedürler, fonksiyonlar ve örnek veriler). Küçük sentaks düzeltmeleri yapıldı; çalıştırmadan önce içindeki veritabanı adını (`TinyHouseDatabase`) gerektiğinde değiştirin.

Nasıl çalıştırılır:

1) SQL Server Management Studio (SSMS) ile:
   - SSMS'i açın, sunucuya bağlanın (ör. `localhost\SQLEXPRESS`).
   - `create_schema.sql` dosyasını açıp Execute (F5) ile çalıştırın.
   - İsterseniz ardından `seed_data.sql` çalıştırın.

2) Komut satırı (Windows): `sqlcmd` örneği
```
sqlcmd -S .\SQLEXPRESS -i "database\\create_schema.sql" -E
sqlcmd -S .\SQLEXPRESS -i "database\\seed_data.sql" -E
```

Notlar:
- Proje içindeki bağlantı stringini güncellemek için `girisEkran.cs` dosyasında bulunan `SqlConnection` satırını kendi sunucu adınıza (ör. `MYPC\\SQLEXPRESS`) göre değiştirin.
- Üretimde kesinlikle düz metin şifre kullanmayın; yalnızca geliştirme/test amaçlı seed parolaları vardır.
