# Product Management API

ASP.NET Core Web API built with Clean Architecture.

## Technologies

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- CQRS
- MediatR
- Repository Pattern
- Swagger

## Architecture

The project is divided into four layers:

- ProductManagement.API
- ProductManagement.Application
- ProductManagement.Domain
- ProductManagement.Infrastructure

## Entities

### Product

- Id
- Name
- Description
- Price
- Stock
- CategoryId

### Category

- Id
- Name
- Description
- Products

Relationship:

One Category has many Products.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/Products | Get all products |
| GET | /api/Products/{id} | Get product by id |
| POST | /api/Products | Create product |
| PUT | /api/Products/{id} | Update product |
| DELETE | /api/Products/{id} | Delete product |

## Database

The project uses SQL Server with Entity Framework Core.

Migrations are included in the Infrastructure layer.

## Swagger

Swagger is enabled and can be used to test all endpoints.

## How to run

1. Open the solution in Visual Studio 2022.
2. Make sure SQL Server LocalDB is installed.
3. Check the connection string in `appsettings.json`.
4. Run the following commands in Package Manager Console:

```powershell
Update-Database