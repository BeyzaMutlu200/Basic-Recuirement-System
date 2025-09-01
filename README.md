# Basic Requirement System (IK Project)

Bu proje, basit bir İnsan Kaynakları (IK) bilgi toplama ve kayıt sistemidir. Kullanıcı bilgilerini toplar, doğrular ve bilgisayarda bir dosyaya kaydeder.  

---

## Özellikler

- Kullanıcı adı ve soyadı, T.C. kimlik numarası, e-posta ve telefon bilgilerini toplar.
- CV dosyasını PDF formatında seçme ve kaydetme.
- Meslek seçimi yapılması zorunludur.
- Bilgi doğrulama: boş alan kontrolü ve T.C. kimlik numarası uzunluk kontrolü.
- Kullanıcı bilgilerini bilgisayarda `cv.txt` dosyasına kaydeder.
- Hatalı veya eksik girişlerde kullanıcıya hata mesajı gösterir.

---

## Kullanılan Teknolojiler

- **C#**
- **Windows Forms (WinForms)**  
- .NET Framework

---

## Dosya Yapısı

- `Form1.cs` : Ana form ve arayüz işlemleri
- `information.cs` : Kullanıcı bilgilerini tutan ve kaydeden sınıf
- `IK.sln` : Visual Studio çözüm dosyası

---

## Kurulum ve Çalıştırma

# 1. Repository'yi klonlayın:
```bash
git clone https://github.com/BeyzaMutlu200/Basic-Recuirement-System.git
```
# 2. Visual Studio ile açın (IK.sln dosyasını kullanın).

# 3. Projeyi derleyin ve çalıştırın.

## Kullanım
```bash
Form üzerindeki alanları doldurun:

Ad Soyad

T.C. Kimlik No

E-posta

Telefon

CV PDF dosyasını seçin (yalnızca .pdf).

Meslek seçimini yapın.

"Kaydet" butonuna basın.

Tüm bilgiler doğrulandıktan sonra cv.txt dosyasına kaydedilecektir.
```
## Notlar

PDF dosya yolu doğru alınmalıdır. label6 alanında "Seç" yazısı eklenmemelidir; yalnızca dosya yolu kullanılacaktır.

.vs/, bin/ ve obj/ klasörleri .gitignore dosyasında yer almalıdır.

Dosyalar C:\Users\Beyza\Desktop\IK\cv.txt yolunda kaydedilir, istenirse SaveToFile metodundan değiştirilebilir.

## İlerleyen Geliştirmeler

CV dosyasının içeriğini okumak ve form üzerinde göstermek.

T.C. kimlik numarası doğrulama algoritması eklemek.

Kullanıcı bilgilerini bir veritabanına kaydetmek.
