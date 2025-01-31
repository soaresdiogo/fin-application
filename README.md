# 🌟 Fin Application
## 📝 Description
A modern .NET Core 8 application built with clean architecture principles, providing robust financial management capabilities.
## 🚀 Technologies & Tools
- [.NET Core 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) - Framework
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - ORM
- [PostgreSQL](https://www.postgresql.org/) - Database
- [JWT Authentication](https://jwt.io/) - Authentication
- [AutoMapper](https://automapper.org/) - Object Mapping
- [FluentValidation](https://fluentvalidation.net/) - Input Validation
- [Swagger/OpenAPI](https://swagger.io/) - API Documentation
- [Docker](https://www.docker.com/) - Containerization
- [Financial Modeling Prep API](https://financialmodelingprep.com/developer/docs/) - Financial Data Provider
## 🏗️ Architecture
Project structure:
```
src/
├── Controllers/           # 🎮 API endpoints
├── Data/                 # 🗄️ Database context and configurations
├── DTOs/                 # 📦 Data Transfer Objects
├── Extensions/           # 🔧 Extension methods
├── Helpers/              # 🛠️ Helper classes
├── Interfaces/           # 📝 Interfaces definitions
├── Mappers/             # 🔄 AutoMapper profiles
├── Migrations/           # 📊 Database migrations
├── Models/              # 💼 Domain models
├── Repository/          # 📁 Data access layer
└── Service/             # 🔧 Business logic layer
```
## 📋 Prerequisites
- 🔧 .NET SDK 8.0
- 🐋 Docker & Docker Compose
- 🗄️ PostgreSQL
- 🔑 Financial Modeling Prep API Key
## 🚀 Getting Started
### 📥 Clone the Repository
```bash
git clone <repository-url>
cd fin-application
```
### 🐳 Database Setup with Docker
```yaml
version: '3.8'
services:
  postgres:
    image: postgres:latest
    environment:
      POSTGRES_USER: your_username
      POSTGRES_PASSWORD: your_password
      POSTGRES_DB: fin_db
    ports:
      - '5432:5432'
    volumes:
      - postgres_data:/var/lib/postgresql/data
volumes:
  postgres_data:
```

### 🗄️ Database Migrations
After setting up your database connection in `appsettings.json`, follow these steps to initialize the database:

```bash
# Install EF Core tools globally (if not already installed)
dotnet tool install --global dotnet-ef

# Create initial migration
dotnet ef migrations add InitialMigration

# Apply migrations to the database
dotnet ef database update
```

### 💻 Running the Application
```bash
dotnet run
```
## ⚙️ Configuration
Configure your application in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=<DATABASE_NAME>;Username=<USERNAME>;Password=<PASSWORD>"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "FMPKey": "<YOUR_FINANCIAL_MODELING_PREP_API_KEY>",
  "JWT": {
    "Issuer": "http://localhost:5246",
    "Audience": "http://localhost:5246",
    "SigningKey": "<HASH KEY>"
  }
}
```
## 🔒 Security Features
- 🔑 JWT Authentication
- 🔐 Role-based Authorization
- 🛡️ HTTPS Enforcement
- 🔒 Secure Password Hashing
- 🌐 CORS Policy Configuration
## 🔧 Development Features
- ⚡ Hot Reload Support
- 🔍 Comprehensive Logging
- 📝 API Documentation with Swagger
- 🔄 Entity Framework Migrations
## 📦 NuGet Packages
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Npgsql.EntityFrameworkCore.PostgreSQL
- Microsoft.AspNetCore.Authentication.JwtBearer
- AutoMapper.Extensions.Microsoft.DependencyInjection
- FluentValidation.AspNetCore
- Swashbuckle.AspNetCore

Made with ❤️ by [Diogo Soares]
