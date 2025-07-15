# GrendeHusCafe

GrendeHusCafe is a distributed application designed to manage and operate a café or similar establishment. The solution is built with .NET technologies, utilizes Aspire for distributed application orchestration, and features Blazor Server Side rendering for a responsive user experience. It leverages modern development practices, including containerization and Entity Framework Core for data access.

## What Makes It Unique?
- **Per-User Store Setup:** Each user can have their own independent café or store setup, with isolated data and management. This makes GrendeHusCafe ideal for community centers, pop-up cafés, or organizations where multiple users need their own separate environments.
- **Aspire & Blazor Server:** Built with Aspire for distributed .NET application management and Blazor Server for efficient, interactive web interfaces.

## Features
- **Order Management:** Track orders, order items, and manage product inventory.
- **Expense Tracking:** Record and categorize café expenses.
- **Work Sessions:** Log and manage work sessions for staff or volunteers.
- **Database Migrations:** Automated database migrations using a dedicated migration service.
- **Modular Architecture:** Projects are separated into logical components for scalability and maintainability.
- **Azure/Local SQL Support:** Easily switch between Azure SQL and local SQL Server for development and production.

## Project Structure
- `App/` - Main Blazor or web application for the café interface.
- `Context/` - Entity Framework Core data models and migrations.
- `MigrationService/` - Service for applying database migrations.
- `GrendeHusCafeAppHost1/` - Application host projects for running and orchestrating the distributed components.
- `ServiceDefaults1/` - Shared service defaults and extensions.

## Getting Started
1. Clone the repository.
2. Build the solution using Visual Studio or `dotnet build`.
3. Configure your database connection in the appropriate `appsettings.json` files.
4. Run the application host to start all services.

## Requirements
- .NET 8.0 or later
- SQL Server (local or Azure)

## License
This project is licensed under the MIT License.