# ZooApp

**Proje Adı:** Hayvanat Bahçesi Hayvan Kayıt ve Ziyaretçi Sistemi  
**Geliştirildiği Ortam:** Microsoft SQL Server, Visual Studio (.NET Framework), Windows Forms  

---

## 1. Projenin Amacı

Bu projenin amacı, bir hayvanat bahçesinde bulunan hayvanların ve ziyaretçilerin sistematik bir şekilde kaydının tutulması, veritabanı üzerinden kolayca erişilebilmesi ve yönetilebilmesidir.

---

## 2. Kullanılan Teknolojiler

- **Microsoft SQL Server 2022:** Veritabanı yönetimi
- **Visual Studio (WinForms):** Grafik kullanıcı arayüzü
- **C#:** SQL bağlantı ve sorgu işlemleri

---

## 3. Veritabanı Yapısı

Veritabanı aşağıdaki üç ana tablodan oluşmaktadır:

- `Animals`:  
  - `AnimalID` (int, PK)  
  - `Name` (nvarchar)  
  - `Species` (nvarchar)  
  - `BirthDate` (datetime)
  - `Habitat` (nvarchar)
  - `HealthStatus` (nvarchar)  

- `Visitors`:  
  - `VisitorID` (int, PK)  
  - `FullName` (nvarchar)
  - `VisitDate` (datetime)
  - `TicketType` (nvarchar)

- `Visits`:  
  - `VisitID` (int, PK)  
  - `VisitorID` (int, FK)  
  - `VisitTime` (datetime)

![Screenshot 2025-06-07 153413](https://github.com/user-attachments/assets/a0f81bf2-853f-4295-a861-10624444bd42)

---

## 4. Uygulama Özellikleri

- Hayvan kayıtlarını listeleme, arama, ekleme ve silme
- Ziyaretçi kayıtlarını listeleme, arama, ekleme ve silme
- Belirli tarih aralığında yapılan ziyaretleri listeleme

---
