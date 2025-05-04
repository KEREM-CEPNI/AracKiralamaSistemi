# 🚗 Araç Kiralama Sistemi

Bu proje, kullanıcıların araç kiralama ve satın alma işlemlerini gerçekleştirebildiği, admin paneli sayesinde içeriklerin yönetilebildiği tam özellikli bir **Araç Kiralama Web Uygulamasıdır**.

## 📌 Proje Özellikleri

### 👤 Kullanıcı Paneli
- **Kayıt Ol & Giriş Yap**: Kullanıcılar sisteme kayıt olabilir ve giriş yaparak oturum açabilir.
- **Araç Kiralama**: Kullanıcılar sistemde listelenen araçları istedikleri tarihler arasında kiralayabilir.
- **Araç Satın Alma**: Bazı araçlar satışa açıktır. Kullanıcılar bu araçları sistem üzerinden satın alabilir.
- **Kiralama Geçmişi**: Kullanıcılar geçmişte yaptıkları kiralama ve satın alma işlemlerini görebilir.
- **Profil Düzenleme**: Kullanıcılar şifre, e-posta gibi bilgilerini güncelleyebilir.

### 🔐 Admin Paneli
- **Araç Yönetimi**: Admin, yeni araç ekleyebilir, mevcut araçları güncelleyebilir veya silebilir.
- **Kullanıcı Yönetimi**: Sistemdeki kullanıcıları listeleyebilir, düzenleyebilir veya silebilir.
- **Rezervasyon Takibi**: Kiralanan/satılan araçları takip edebilir.
- **Kategori ve Marka Yönetimi**: Araç kategorileri ve markaları üzerinde düzenleme yapılabilir.
- **Raporlama**: Günlük/aylık kiralama, satış raporları alınabilir.

### 🚘 Araç Özellikleri
- Araç Adı, Markası, Model Yılı, Fiyatı (kiralama/satış), Yakıt Türü, Vites Tipi gibi detaylar kullanıcıya gösterilir.
- Araçlar galeri görünümünde listelenir.
- Fotoğraf ekleme desteği vardır.

### 📅 Gelişmiş Rezervasyon Sistemi
- Kullanıcı, tarih seçerek araç kiralama işlemini gerçekleştirebilir.
- Aynı aracın aynı tarihte başka bir kullanıcıya verilmesi engellenir.
- Çift rezervasyon kontrolü mevcuttur.

## 🧑‍💻 Kullanılan Teknolojiler

- **Frontend**: HTML, CSS, JavaScript, Bootstrap
- **Backend**: PHP / Laravel (veya seçilen framework)
- **Veritabanı**: MySQL
- **Oturum Yönetimi**: PHP Session / JWT
- **Admin Paneli**: Bootstrap AdminLTE / özel geliştirme

## ⚙️ Kurulum ve Kullanım

1. Projeyi klonlayın:
    ```bash
    git clone https://github.com/kullaniciAdi/arac-kiralama-sistemi.git
    ```

2. Veritabanı oluşturun:
    - `arac_kiralama.sql` dosyasını içeri aktarın.
    - `.env` dosyasında veritabanı ayarlarınızı yapın.

3. PHP sunucusunu çalıştırın:
    ```bash
    php -S localhost:8000
    ```

4. Tarayıcıda şu adresi açın:
    ```
    http://localhost:8000
    ```

5. **Admin Girişi için Örnek Bilgiler:**
    - Kullanıcı: `admin@example.com`
    - Şifre: `admin123`



