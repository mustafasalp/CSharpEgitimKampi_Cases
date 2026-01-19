### Screenshots

## Login Form
<img width="394" height="527" alt="Ekran görüntüsü 2026-01-19 143704" src="https://github.com/user-attachments/assets/032aa02e-efaa-415a-8ee9-27d4fef1a70e" />

## Dashboard Form
<img width="1196" height="649" alt="Ekran görüntüsü 2026-01-19 143714" src="https://github.com/user-attachments/assets/396f9646-965c-4879-ac19-40aaa12ae454" />

## Spendings Form
<img width="1165" height="600" alt="Ekran görüntüsü 2026-01-19 143723" src="https://github.com/user-attachments/assets/3810709e-bc05-43d9-bf9e-510c4cf86f86" />

## Categories Form
<img width="1166" height="595" alt="Ekran görüntüsü 2026-01-19 143732" src="https://github.com/user-attachments/assets/ae8a692b-9672-45f0-a097-8232642ead02" />

## Settings Form
<img width="394" height="537" alt="Ekran görüntüsü 2026-01-19 143739" src="https://github.com/user-attachments/assets/88666c9b-993f-4358-b8e1-13f8e70b1700" />

## Bank Processes Form 
<img width="1236" height="650" alt="Ekran görüntüsü 2026-01-19 143823" src="https://github.com/user-attachments/assets/90520df3-45ef-4f45-8a72-4a2bff9930f3" />

# MyFinancialCrm

Bu proje, C# ve Windows Forms teknolojileri kullanılarak geliştirilmiş, kişisel finans yönetimini kolaylaştırmayı amaçlayan kapsamlı bir CRM uygulamasıdır. Kullanıcıların banka süreçlerini, faturalarını, harcamalarını ve finansal kategorilerini tek bir yerden takip etmelerine olanak tanır.

## Özellikler

Uygulama aşağıdaki temel modülleri içerir:

- **Kullanıcı Girişi ve Kaydı:** Güvenli oturum açma ve yeni kullanıcı kayıt işlemleri.
- **Dashboard (Genel Bakış):** Finansal durumun özetlendiği ana ekran.
- **Banka Yönetimi:** Banka hesaplarının ve bakiye durumlarının takibi.
- **Banka Hareketleri:** Hesap hareketlerinin detaylı görüntülenmesi.
- **Fatura Takibi:** Ödenmiş ve ödenecek faturaların yönetimi.
- **Harcama Yönetimi:** Yapılan harcamaların kategorize edilerek kaydedilmesi.
- **Kategori İşlemleri:** Gelir ve gider kategorilerinin düzenlenmesi.
- **Ayarlar:** Kullanıcı profili ve uygulama ayarlarının yapılandırılması.

## Teknolojiler

Proje geliştirilirken aşağıdaki teknolojiler kullanılmıştır:

- **Programlama Dili:** C#
- **Framework:** .NET Framework 4.7.2
- **Arayüz:** Windows Forms (WinForms)
- **ORM:** Entity Framework 5.0 (Db First / Model First yaklaşımı)
- **Veritabanı:** Microsoft SQL Server

## Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi İndirin:** Bu depoyu (repository) yerel makinenize klonlayın veya zip olarak indirin.
2.  **Visual Studio ile Açın:** `MyFinancialCrm.sln` çözüm dosyasını Visual Studio'da açın.
3.  **Paketleri Yükleyin:** NuGet Paket Yöneticisi aracılığıyla gerekli bağımlılıkları yükleyin/geri yükleyin.
4.  **Veritabanı Yapılandırması:**
    - SQL Server veritabanınızın hazır olduğundan emin olun.
    - `App.config` dosyasındaki bağlantı dizesini (connection string) kendi veritabanı sunucunuza göre güncelleyin.
5.  **Uygulamayı Çalıştırın:** F5 tuşuna basarak veya "Start" butonuna tıklayarak uygulamayı derleyin ve çalıştırın.

## Katkıda Bulunma

Projeye katkıda bulunmak isterseniz:

1.  Bu depoyu forklayın.
2.  Yeni bir özellik için dal (branch) oluşturun (`git checkout -b feature/YeniOzellik`).
3.  Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`).
4.  Dalınıza push yapın (`git push origin feature/YeniOzellik`).
5.  Bir Pull Request (Çekme İsteği) oluşturun.

## Lisans

Bu proje açık kaynaklıdır ve geliştirme amaçlı sunulmuştur.
