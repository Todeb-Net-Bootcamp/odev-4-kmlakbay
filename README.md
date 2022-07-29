### Database'i kurmak için:
### 1. DataAccessLayer/Contexts/BootcampdbContext.cs dosyasında ilgili alana database'i kurmak istediğiniz server bilgilerini yazarak düzenlemelisiniz.
![image](https://user-images.githubusercontent.com/36498886/180485327-46edf856-fed5-42ec-bc6f-8fa7c5492727.png)

### 2. Migration'ları çalıştamalısınız. 

(PackageManagerConsole'da yapabilirsiniz.)

![image](https://user-images.githubusercontent.com/36498886/180485912-44525a8b-e2aa-4a07-a063-433488cb600a.png)

### 2.1 Migration Snapshot ekleyerek migration oluşturmalısınız. 

<code>add-migration CreateDbObjectsAndSampleData -outputDir Migrations</code> 

![image](https://user-images.githubusercontent.com/36498886/180486089-c427feb6-bdd3-4595-bdfc-52482c90454e.png)

### 2.2 Eklenilen migration'lar ile veritabanını güncellemelisiniz.

<code>update-database</code>

![image](https://user-images.githubusercontent.com/36498886/180487888-922fb0f5-99ed-4dc0-ab1b-8ee63788dd1c.png)


## Not: Test edilebilmesi için context oluşturulurken örnek veriler eklenmiştir. ConsoleUI projesi kullanılarak örnek veriler ile test edilebilir. 



<hr />

### odev-4
7. Hafta sonunda tanımlayacağımız Web Api Projesinin(BİTİRME PROJESİ DEĞİL) Codefirst yaklaşımı kullanılarak DataAccessLayer katmanını oluşturacağız. 
### Son Teslim Tarihi: 22 Temmuz Cuma saat 23.00
