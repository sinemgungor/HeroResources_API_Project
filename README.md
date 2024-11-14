HeroMaster, çalışan yönetimi, departman yönetimi ve kullanıcı doğrulama işlemlerini gerçekleştiren bir API projesidir. Bu proje, çalışanları eklemek, 
çalışanların yöneticilerinden avans,izin, bütçe talep etmeleri, departmanlara çalışanlar eklemek, şifre sıfırlama, kullanıcı doğrulama ve diğer ilgili işlemleri yönetmek için 
çeşitli işlevler sunmaktadır.

Proje, iş gücü yönetimini kolaylaştırmayı amaçlayan, RESTful API hizmetleri sağlayan bir backend çözümü olarak geliştirilmiştir.

Kullanılan Teknolojiler:
Backend: ASP.NET Core Web API
Veritabanı: Entity Framework Core
Kimlik Doğrulama: ASP.NET Core Identity
Teknik Yapı: Clean Architecture, Dependency Injection, Service Layer
API İstekleri: Swagger/OpenAPI
Diğer: JWT Authentication, Role-based Authorization
Proje Özellikleri:
Kullanıcı Giriş ve Çıkış İşlemleri: Kullanıcıların giriş yapabilmesi, şifre sıfırlama ve e-posta doğrulama işlemleri.
Çalışan Yönetimi: Çalışan ekleme, güncelleme, departman atama gibi yönetimsel işlemler.
Departman ve Yönetici Atamaları: Çalışanlara departman atama ve yöneticilere departman yöneticisi rolü verme.
Manager Role: Yöneticilerin kendi ekiplerini yönetebilmesi için rol tabanlı erişim.
CEO Yönetimi: CEO'ların listelenmesi ve yönetici rolüne atanması.
Email Doğrulama: Kullanıcıların hesaplarını doğrulamak için e-posta doğrulama mekanizması.
JWT Token: Kullanıcı doğrulaması ve güvenlik için JWT token kullanımı.
