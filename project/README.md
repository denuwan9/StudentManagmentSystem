# Student Management System

A complete Student Management System for Skills International School built with C# Windows Forms and SQL Server.

## Features

- **Login System**: Secure login with default credentials (Admin/Skills@123)
- **Student Registration**: Complete CRUD operations for student records
- **Data Validation**: Comprehensive validation for all input fields
- **Search Functionality**: Search students by registration number
- **Professional UI**: Modern, color-coded interface with proper grouping

## Technology Stack

- **Language**: C# (.NET 6.0)
- **UI Framework**: Windows Forms
- **Database**: SQL Server
- **IDE**: Visual Studio 2022 or later

## Prerequisites

1. **Visual Studio 2022** or later with .NET 6.0 SDK
2. **SQL Server** (Express, Developer, or Standard edition)
3. **SQL Server Management Studio (SSMS)** (optional, for database management)

## Installation & Setup

### Step 1: Database Setup

1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your SQL Server instance
3. Open the script file: `Database/Script.sql`
4. Execute the script to create the database and tables
5. Verify that the `Student` database and `Registration` table are created

### Step 2: Configure Connection String

1. Open `App.config` file
2. Update the connection string in the `<connectionStrings>` section:
   ```xml
   <add name="StudentDBConnection" 
        connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True" 
        providerName="System.Data.SqlClient" />
   ```
   Replace `YOUR_SERVER_NAME` with your SQL Server instance name (e.g., `localhost`, `localhost\SQLEXPRESS`, or your server name)

### Step 3: Build and Run

1. Open the project in Visual Studio
2. Restore NuGet packages (if prompted)
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

## Default Login Credentials

- **Username**: `Admin`
- **Password**: `Skills@123`

## Project Structure

```
StudentManagementSystem/
├── Database/
│   └── Script.sql              # Database creation script
├── Data/
│   └── DatabaseConnection.cs   # Database connection handler
├── Forms/
│   ├── LoginForm.cs            # Login form code-behind
│   ├── LoginForm.Designer.cs   # Login form designer
│   ├── RegistrationForm.cs     # Registration form code-behind
│   └── RegistrationForm.Designer.cs  # Registration form designer
├── Helpers/
│   └── ValidationHelper.cs     # Input validation utilities
├── Models/
│   └── Student.cs              # Student model class
├── Repositories/
│   ├── StudentRepository.cs   # Student CRUD operations
│   └── UserRepository.cs      # User authentication
├── App.config                  # Application configuration
├── Program.cs                  # Application entry point
└── StudentManagementSystem.csproj  # Project file
```

## Database Schema

### Registration Table
- `regNo` (INT, PRIMARY KEY)
- `firstName` (VARCHAR(50))
- `lastName` (VARCHAR(50))
- `dateOfBirth` (DATETIME)
- `gender` (VARCHAR(50))
- `address` (VARCHAR(50))
- `email` (VARCHAR(50))
- `mobilePhone` (INT)
- `homePhone` (INT)
- `parentName` (VARCHAR(50))
- `nic` (VARCHAR(50))
- `contactNo` (INT)

### Users Table (Optional)
- `userId` (INT, PRIMARY KEY, IDENTITY)
- `username` (VARCHAR(50), UNIQUE)
- `password` (VARCHAR(100))

## Features Overview

### Login Form
- Username and password authentication
- Clear button to reset fields
- Exit button with confirmation dialog
- Default credentials support

### Registration Form
- **Register**: Insert new student records
- **Update**: Modify existing student records
- **Delete**: Remove student records (with confirmation)
- **Clear**: Reset all input fields
- **Search**: Select registration number from dropdown to auto-fill fields
- **Logout**: Return to login form
- **Exit**: Close application with confirmation

### Validation Features
- Email format validation
- Phone number validation (10 digits)
- NIC validation (9 or 12 digits)
- Required field validation
- Date of birth age restrictions (5-100 years)
- Future date prevention

## Usage Instructions

### Adding a New Student
1. Login with credentials
2. Enter or select a registration number
3. Fill in all required fields
4. Click "Register" button
5. Success message will appear

### Updating a Student
1. Select registration number from dropdown
2. Modify the fields as needed
3. Click "Update" button
4. Success message will appear

### Deleting a Student
1. Select registration number from dropdown
2. Click "Delete" button
3. Confirm deletion in the dialog
4. Success message will appear

### Searching for a Student
1. Select registration number from dropdown
2. All fields will automatically populate with student data

## Troubleshooting

### Connection String Issues
- Verify SQL Server is running
- Check server name in connection string
- Ensure Windows Authentication is enabled
- Try using `localhost` or `localhost\SQLEXPRESS` for local instances

### Database Not Found
- Run the `Database/Script.sql` script
- Verify database name is "Student"
- Check table names match exactly

### Build Errors
- Restore NuGet packages
- Ensure .NET 6.0 SDK is installed
- Check all references are properly added

## Development Notes

- Uses parameterized queries to prevent SQL injection
- Proper exception handling throughout
- Disposable pattern for database connections
- Follows C# naming conventions
- Professional UI with color-coded buttons

## License

This project is created for educational purposes.

## Author

Student Management System - Skills International School


