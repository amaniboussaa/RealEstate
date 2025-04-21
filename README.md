# 🧼 .NET Clean Architecture Demo with Domain-Driven Design

This is a sample solution demonstrating **Clean Architecture** and **Domain-Driven Design** using .NET. It separates concerns across different layers and promotes scalability, testability, and maintainability.

---

## 🏗️ Architecture Overview
## 🔍 Layer Details

### 🎯 Domain Layer
- Contains enterprise/business logic
- **Includes:**
  - Entities
  - Interfaces
- ❌ No dependencies on other layers

---

### 🔄 Application Layer
- Contains application-specific logic and use cases
- **Includes:**
  - DTOs
  - Interfaces
  - Service Implementations
- ✅ Depends only on the Domain layer

---

### 🛠️ Infrastructure Layer
- Implements interfaces from Domain and Application layers
- **Includes:**
  - Database contexts
  - Repository implementations
- ✅ Depends on Application layers

---

### 🌐 WebApi Layer
- Presentation layer exposing RESTful APIs
- **Includes:**
  - API Controllers
- ✅ Depends on Application layer

---

## 🚀 Getting Started

### ✅ Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/en-us/download) or later
- Visual Studio 2022 or Visual Studio Code
- SQL Server 

---

### 🛠️ Installation

1. **Clone the repository**

```bash
git clone https://github.com/amaniboussaa/RealEstate.git
cd RealEstate

```
2. **Build the solution**

```bash
dotnet build
```
3. **Run the application**

```bash
cd RealEstate.API
dotnet run
```
## 📡 API Endpoints (Property API)

| Method | Endpoint              | Description               |
|--------|-----------------------|---------------------------|
| GET    | `/api/propertys`      | Get all properties        |
| GET    | `/api/propertys/{id}` | Get property by ID        |
| POST   | `/api/propertys`      | Create new property       |
| PUT    | `/api/propertys/{id}` | Update existing property  |
| DELETE | `/api/propertys/{id}` | Delete property           |

---

## 🧰 Technology Stack

- **.NET 7.0**: High-performance modern development framework  
- **Entity Framework Core**: ORM for data access  
- **Swagger / OpenAPI**: For interactive API documentation  
- **SQL Server Express**: Optional, used for real DB testing  

----------------------------------
all .NET 7 pas 4
1- create project Projectname.API : asp.net core web api( fait attention c# et non pas visual basic)
	solution name virer le moy api
	reference : Application/Infrastructure
2- add project Projectname.Domain : class library
	-entity
	-repository
3- add project Projectname.Application : class library
4- add project Projectname.Infrastructure : class library
	reference:Application
5- in programc: add infrastructure

6/ in infra and api install this : 
  Microsoft.EntityFrameworkCore" Version="7.0.0" />
  Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.0" />
  Microsoft.EntityFrameworkCore.Tools" Version="7.0.0">
  Microsoft.EntityFrameworkCore.design" Version="7.0.0">
and design

7- 
	dotnet build
	Add-Migration firstinitial
	update-database
 https://medium.com/@jenilsojitra/clean-architecture-net-solution-template-a8598f0a4803

