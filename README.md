# User Management API

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-12.0-239120?style=flat&logo=c-sharp)
![EF Core](https://img.shields.io/badge/EF%20Core-8.0-512BD4?style=flat)
![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?style=flat&logo=microsoft-sql-server)

A robust **Backend RESTful API** built with **ASP.NET Core 8.0** to manage users. This project demonstrates modern backend development practices in C#, moving beyond in-memory data structures to full database persistence using **Entity Framework Core** and **SQL Server**.

## 🚀 Features

- **Full CRUD Operations**: Create, Read, Update, and Delete users.
- **Database Persistence**: Uses **SQL Server LocalDB** to store data permanently.
- **Entity Framework Core**: Utilizes **EF Core** as the **ORM** for database interactions.
- **Layered Architecture**: Implements the **Service Pattern** to separate business logic (`UserService`) from the API controllers (`UsersController`).
- **Dependency Injection**: Uses ASP.NET Core's built-in DI container for managing services and database contexts.
- **Swagger UI**: Integrated OpenAPI documentation for interactive API testing.

## 🛠️ Tech Stack

- **Framework**: .NET 8.0 (ASP.NET Core Web API)
- **Language**: C#
- **Database**: Microsoft SQL Server (LocalDB)
- **ORM**: Entity Framework Core 8.x
- **Documentation**: Swagger / Swashbuckle

## 📂 Project Structure

The project follows a clean separation of concerns:

- **`Controllers/`**: Handles incoming HTTP requests and returns responses.
- **`Services/`**: Contains business logic and interacts with the database context.
- **`Data/`**: Contains the `AppDbContext` configuration and database sets.
- **`Models/`**: Defines the domain entities (e.g., `User`).
- **`Migrations/`**: EF Core migration files to manage database schema changes.

## ⚙️ Getting Started

Follow these steps to run the project locally.

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Recommended) or VS Code.

### Installation

**1. Clone the repository**

Start by cloning the repository to your local machine:

```bash
git clone https://github.com/Kaua-Rossi/User-Management-API.git
cd User-Management-API
```

**2. Configure the Database**

The project uses LocalDB by default, and the connection string is already configured in appsettings.json. To create the actual database and tables, you need to apply the migrations.

Using Visual Studio (Package Manager Console):

```powershell
Update-Database
```

Or using the .NET CLI in your terminal:
```bash
dotnet ef database update
```
**3. Run the Application**

You can run the project directly from Visual Studio by pressing F5 or the Play button.

Alternatively, run it via the terminal:
```bash
dotnet run
```
**4. Access Swagger**

Once the application is running, your browser should open automatically to the Swagger UI page. If not, navigate to:

https://localhost:{PORT}/swagger

## 🔌 API Endpoints

| Method       | Endpoint          | Description                |
| :----------- | :---------------- | :------------------------- |
| `GET`        | `/api/Users`      | Retrieve all users         |
| `GET`        | `/api/Users/{id}` | Retrieve a user by ID      |
| `POST`       | `/api/Users`      | Create a new user          |
| `PUT`        | `/api/Users/{id}` | Update an existing user    |
| `DELETE`     | `/api/Users/{id}` | Delete a user              | 

## 📚 Project Context

This project was developed to solidify my knowledge in .NET Back-end development. It serves as a practical application of basic/intermediate fundamental concepts, marking my transition from basic syntax to building robust, scalable web applications.

**Key Learning Outcomes:**

* **RESTful API Development:** Building a complete web service from scratch, understanding the Request/Response lifecycle, and implementing standard HTTP verbs for a CRUD application (GET, POST, PUT, DELETE).
* **Database Persistence & ORM:** Managing the critical transition from volatile in-memory data structures to permanent storage using **SQL Server**, orchestrated by **Entity Framework Core** as the **ORM**.
* **Software Architecture:** Refactoring code into a **Layered Architecture** (Service Pattern), decoupling business logic from API controllers to ensure clean and maintainable code.
* **.NET Ecosystem & Tooling:** Gaining proficiency with the professional development environment, including **Visual Studio 2022**, dependency management with **NuGet**, and interactive documentation with **Swagger UI**.

This repository demonstrates my ability and learning progress in building structured, maintainable, and functional APIs using modern Microsoft technologies. 

And that's it :)

---

🌠 Developed by [Kauã Rossi](https://www.github.com/Kaua-Rossi)
