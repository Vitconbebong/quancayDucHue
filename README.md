# Sales Management (QuanCayDucHue)

This is a sales management application built on the Windows Forms platform.

## Technologies Used

- **Language**: C#
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Database**: SQL Server
- **Architecture**: MVC (Model-View-Controller)

## Project Structure

- `QuanLyBanHang/Controllers`: Contains business logic and controllers.
- `QuanLyBanHang/Models`: Contains classes for interacting with the database (using ADO.NET).
- `QuanLyBanHang/Views`: Contains the user interface (Forms).
- `DataBase`: Contains SQL scripts for initializing the database.

## Installation and Setup

### 1. Database Preparation

1. Open SQL Server Management Studio (SSMS).
2. Run the SQL script files in the `QuanCayDucHue/DataBase/` directory in the following order:
   - `Data.sql`: Creates tables and sample data.
   - `Permission.sql`: Sets up permissions (if applicable).

### 2. Connection Configuration

By default, the connection string is configured for the server `VITCONBEBONG`. You need to change this to match your environment.

1. Open the file `QuanCayDucHue/QuanLyBanHang/Models/ADO.cs`.
2. Find the `sqlConnection` method and the `connectionString` variable:
   ```csharp
   string connectionString = $@"server = VITCONBEBONG;
                                database = QuanLyBanHang;
                                user = {username};
                                password = {password};";
   ```
3. Change `server = VITCONBEBONG` to your SQL Server instance name (e.g., `server = .\\SQLEXPRESS` or `server = localhost`).

### 3. Running the Application

1. Open the solution file `QuanCayDucHue/QuanCayDucHue.sln` with Visual Studio.
2. Press **Start** or **F5** to build and run the application.

## System Requirements

- Visual Studio (2019 or newer).
- SQL Server.
- .NET Framework 4.7.2.
