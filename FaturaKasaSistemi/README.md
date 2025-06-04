# Fatura Kasa Sistemi

Bu proje, C# ve Windows Forms ile geliştirilmiş bir fatura ve kasa yönetim sistemidir. Kullanıcı dostu arayüzü ile ürün, müşteri, fatura işlemleri ve kasa raporları kolayca yönetilebilir.

## Özellikler
- Ürün tanımlama ve listeleme
- Müşteri ekleme ve listeleme
- Fatura oluşturma ve PDF olarak dışa aktarma
- Fatura arama/listeleme ve seçili faturayı PDF olarak dışa aktarma
- Kasa raporu ve günlük satış takibi
- Dinamik olarak güncellenen saat
- Tüm para birimleri Türk Lirası (₺) olarak gösterilir

## Kurulum

### Geliştirici Kurulumu
1. Projeyi klonlayın:
   ```
   git clone https://github.com/metesahankurt/faturaSistemi
   ```
2. Visual Studio ile açın ve çalıştırın.

### Müşteri Kurulumu
1. Projeyi bilgisayarınıza indirin
2. PowerShell veya Command Prompt'u yönetici olarak açın
3. Projenin bulunduğu klasöre gidin:
   ```
   cd FaturaKasaSistemi
   ```
4. Aşağıdaki komutu çalıştırın:
   ```
   dotnet publish -c Release -r win-x64 --self-contained true
   ```
5. Yayınlanan dosyalar şu klasörde oluşturulacak:
   ```
   bin/Release/net9.0-windows7.0/win-x64/publish/
   ```
6. Bu klasördeki tüm dosyaları (özellikle .exe, .json ve .ico dosyaları) aynı klasöre kopyalayın
7. FaturaKasaSistemi.exe'yi çalıştırın

## Önemli Notlar
- Tüm dosyaların (.exe, .json, .ico) aynı klasörde olduğundan emin olun
- Uygulama ilk kez çalıştırıldığında veritabanı otomatik olarak oluşturulacaktır
- Herhangi bir sorun yaşarsanız, tüm dosyaların doğru konumda olduğunu kontrol edin

## Kod Satırı
Toplam kod satırı: **5167**

## Katkı ve Lisans
Bu proje eğitim amaçlıdır. Katkıda bulunmak için pull request gönderebilirsiniz.

---
 