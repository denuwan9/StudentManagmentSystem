# How to Run the Student Management System

## Quick Start Guide

### Step 1: Prerequisites Check

Make sure you have installed:
- ✅ **Visual Studio 2022** (or later) with .NET 6.0 SDK
- ✅ **SQL Server** (Express, Developer, or Standard edition)
- ✅ **SQL Server Management Studio (SSMS)** - Optional but recommended

### Step 2: Set Up the Database

#### Option A: Using SQL Server Management Studio (Recommended)

1. **Open SQL Server Management Studio (SSMS)**
   - Click Start → Search "SQL Server Management Studio"
   - Connect to your SQL Server instance (usually `localhost` or `localhost\SQLEXPRESS`)

2. **Open the Database Script**
   - In SSMS, click File → Open → File
   - Navigate to: `Database/Script.sql`
   - Open the file

3. **Execute the Script**
   - Click the "Execute" button (or press F5)
   - Wait for the message: "Command(s) completed successfully"
   - Verify the database was created:
     - In Object Explorer, expand "Databases"
     - You should see "Student" database
     - Expand "Student" → "Tables" → You should see "Registration" and "Users" tables

#### Option B: Using Command Line (Alternative)

1. Open **Command Prompt** or **PowerShell** as Administrator
2. Navigate to your project folder
3. Run:
   ```cmd
   sqlcmd -S localhost -i "Database\Script.sql"
   ```
   (Replace `localhost` with your SQL Server instance name if different)

### Step 3: Configure Connection String (If Needed)

1. **Find Your SQL Server Instance Name**
   - Open SQL Server Configuration Manager
   - Or check in SSMS connection dialog
   - Common names: `localhost`, `localhost\SQLEXPRESS`, `.\SQLEXPRESS`, or your computer name

2. **Update App.config** (if your server name is different from `localhost`)
   - Open `App.config` file
   - Find this line:
     ```xml
     connectionString="Data Source=localhost;Initial Catalog=Student;..."
     ```
   - Replace `localhost` with your SQL Server instance name
   - Examples:
     - `Data Source=localhost\SQLEXPRESS;...` (for SQL Express)
     - `Data Source=.\SQLEXPRESS;...` (for local SQL Express)
     - `Data Source=YOUR_COMPUTER_NAME;...` (for named instance)

### Step 4: Open and Build the Project

1. **Open Visual Studio**
   - Launch Visual Studio 2022

2. **Open the Solution**
   - Click File → Open → Project/Solution
   - Navigate to your project folder
   - Select `StudentManagementSystem.sln`
   - Click Open

3. **Restore NuGet Packages** (if prompted)
   - Right-click on the solution in Solution Explorer
   - Select "Restore NuGet Packages"
   - Wait for packages to restore

4. **Build the Project**
   - Press `Ctrl + Shift + B` (or Build → Build Solution)
   - Check the Output window for any errors
   - Should see: "Build succeeded"

### Step 5: Run the Application

1. **Start the Application**
   - Press `F5` (or click the green "Start" button)
   - The Login Form should appear

2. **Login**
   - **Username**: `Admin`
   - **Password**: `Skills@123`
   - Click "Login" button

3. **Use the Registration Form**
   - Enter student details
   - Click "Register" to add a new student
   - Select a registration number from dropdown to search/update/delete

## Troubleshooting

### Problem: "Cannot connect to database" or SQL Server errors

**Solutions:**
1. **Check SQL Server is running**
   - Open Services (services.msc)
   - Find "SQL Server (MSSQLSERVER)" or "SQL Server (SQLEXPRESS)"
   - Ensure it's "Running"

2. **Verify connection string**
   - Check `App.config` has correct server name
   - Try different server names:
     - `localhost`
     - `localhost\SQLEXPRESS`
     - `.\SQLEXPRESS`
     - Your computer name

3. **Test connection manually**
   - Open SSMS and try connecting with the same server name
   - If SSMS can't connect, fix that first

### Problem: "Database 'Student' does not exist"

**Solution:**
- Run the `Database/Script.sql` script again
- Make sure you're connected to the correct SQL Server instance

### Problem: Build errors about missing packages

**Solutions:**
1. Right-click solution → "Restore NuGet Packages"
2. If that doesn't work:
   - Tools → NuGet Package Manager → Package Manager Console
   - Run: `dotnet restore`

### Problem: "ConfigurationManager not found" error

**Solution:**
- The package `System.Configuration.ConfigurationManager` should be installed
- If not, install it via NuGet Package Manager

### Problem: Application runs but forms don't appear

**Solution:**
- Check if forms are set as startup forms
- Verify `Program.cs` has `Application.Run(new LoginForm());`

## Quick Test Checklist

After running, test these features:

- [ ] Login with Admin/Skills@123 works
- [ ] Login with wrong credentials shows error
- [ ] Clear button clears fields
- [ ] Exit button shows confirmation
- [ ] Register button adds new student
- [ ] ComboBox shows registration numbers
- [ ] Selecting from ComboBox fills all fields
- [ ] Update button modifies records
- [ ] Delete button removes records (with confirmation)
- [ ] Logout returns to login form

## Alternative: Run from Command Line

If you prefer command line:

```cmd
# Navigate to project folder
cd "C:\Users\Denuwan\Desktop\Denuwan\kj ge wadak\project"

# Restore packages
dotnet restore

# Build
dotnet build

# Run
dotnet run
```

## Need Help?

If you encounter issues:
1. Check the error message in Visual Studio Output window
2. Verify SQL Server is running
3. Ensure database and tables exist
4. Check connection string matches your SQL Server instance


