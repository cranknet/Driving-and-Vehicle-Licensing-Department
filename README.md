# 🚗 DVLD - Driving and Vehicle Licensing Department System

A complete desktop application for managing the workflow of a government Driving and Vehicle Licensing Department. The system includes person registration, license services, exam scheduling, and user authentication.

> ✅ **Built using C# (.NET Framework), Windows Forms, and SQL Server**  
> ✅ **Implements a 3-Tier Architecture (Presentation, Business Logic, Data Access)**  
> ✅ **Focuses on maintainability, reusability, and a professional UI/UX experience**

---

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [System Features](#system-features)
- [Entities](#entities)
- [System Requirements](#system-requirements)
- [Technologies Used](#technologies-used)
- [Database Design](#database-design)
- [Architecture](#architecture)
- [Future Enhancements](#future-enhancements)

---

## 🧭 Project Overview

The DVLD system replaces outdated manual or semi-digital methods used in managing person data, driving license issuance, exam tracking, and international license applications. It ensures secure, scalable, and user-friendly operations with role-based access.

---

## 🚀 System Features

### 🔐 User Management
- Login with username and password
- “Remember Me” option
- Password visibility toggle

### 👤 Person Management
- Add, update, delete, and search person records
- Assign National ID, name, gender, date of birth, and address

### 📝 Exams
- Schedule and assign theoretical and practical exams
- Record pass/fail results for each attempt
- Track eligibility based on exam performance

### 🪪 Local License Management
- Issue new driving licenses based on exam results
- Renew expired or soon-to-expire licenses
- Replace damaged or lost licenses
- Withdraw licenses temporarily or permanently

### 🌍 International License Services
- Allow eligible users to apply for international driving licenses based on local license status

---

## 🧩 Entities

- **User**: System user account for DVLD staff
- **Person**: Citizen applying for services
- **License**: Represents issued driving licenses
- **Exam**: Practical or theoretical exams for license eligibility
- **Application**: Tracks service applications (e.g., license renewal, replacement)
- **LicenseClass**: Defines categories like motorcycles, cars, heavy trucks, etc.
- **TestAppointment**: Represents scheduled exams
- **TestResult**: Stores exam result per person

---

## ⚙️ System Requirements

- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later
- SQL Server 2016 or later

---

## 🧱 Technologies Used

- **Frontend**: Windows Forms (.NET Framework)
- **Backend**: ADO.NET with SQL Server
- **UI Elements**: UserControls for reusability
- **Design Style**: Professional (blue & gray palette, ARGB(41; 128; 185))

---

## 🏗️ Architecture

The DVLD system is structured into the following tiers:

```
DVLD/
├── Presentation Layer   // Forms, controls, UI logic
├── Business Logic Layer // Rules, validation, workflows
└── Data Access Layer    // SQL, ADO.NET, and CRUD operations
```

---

## 🗃️ Database Design

- Uses a relational model
- All entities are normalized to reduce redundancy
- Primary and foreign key constraints implemented
- Stored procedures used for secure data manipulation

---

## 🔮 Future Enhancements

- Add reporting dashboard with charts (license stats, pass rates)
- Add barcode integration for licenses
- Localize UI to support Arabic and English
- Add WPF version with MVVM architecture
- Integrate biometric or photo capturing for user profiles

---

## 🛠️ Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/DVLD.git
   ```

2. Open the solution in Visual Studio

3. Create the SQL Server database using the included scripts

4. Update the connection string in `App.config`

5. Build and run the project

---
