# PowerShell script to setup and restore all dependencies
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Student Management System Setup" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Check if .NET SDK is installed
Write-Host "Checking .NET SDK..." -ForegroundColor Yellow
try {
    $dotnetVersion = dotnet --version
    Write-Host "✓ .NET SDK found: $dotnetVersion" -ForegroundColor Green
} catch {
    Write-Host "✗ .NET SDK not found!" -ForegroundColor Red
    Write-Host "  Please install .NET 6.0 SDK from: https://dotnet.microsoft.com/download" -ForegroundColor Yellow
    exit
}
Write-Host ""

# Navigate to project directory
$projectPath = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $projectPath

# Restore NuGet packages
Write-Host "Restoring NuGet packages..." -ForegroundColor Yellow
try {
    dotnet restore
    Write-Host "✓ NuGet packages restored successfully!" -ForegroundColor Green
} catch {
    Write-Host "✗ Failed to restore packages" -ForegroundColor Red
    Write-Host "  Error: $_" -ForegroundColor Red
}
Write-Host ""

# Build the project
Write-Host "Building project..." -ForegroundColor Yellow
try {
    dotnet build
    Write-Host "✓ Project built successfully!" -ForegroundColor Green
} catch {
    Write-Host "✗ Build failed" -ForegroundColor Red
    Write-Host "  Error: $_" -ForegroundColor Red
}
Write-Host ""

# Check SQL Server connection
Write-Host "Checking SQL Server connection..." -ForegroundColor Yellow
Write-Host "  (This will test common connection strings)" -ForegroundColor Gray
Write-Host ""

$testConnections = @(
    "localhost",
    "localhost\SQLEXPRESS",
    ".\SQLEXPRESS",
    ".",
    "$env:COMPUTERNAME"
)

$foundServer = $false
foreach ($server in $testConnections) {
    try {
        $connection = New-Object System.Data.SqlClient.SqlConnection("Server=$server;Integrated Security=True;Connection Timeout=2;TrustServerCertificate=True")
        $connection.Open()
        $connection.Close()
        Write-Host "✓ SQL Server found: $server" -ForegroundColor Green
        Write-Host ""
        Write-Host "  → Update App.config connection string to:" -ForegroundColor Cyan
        Write-Host "    Data Source=$server" -ForegroundColor White
        $foundServer = $true
        break
    }
    catch {
        # Silently continue
    }
}

if (-not $foundServer) {
    Write-Host "✗ Could not find SQL Server automatically" -ForegroundColor Red
    Write-Host "  Please run FindSQLServer.ps1 to find your SQL Server instance" -ForegroundColor Yellow
    Write-Host "  Or check SQL Server Configuration Manager" -ForegroundColor Yellow
}
Write-Host ""

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Setup Complete!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "Next steps:" -ForegroundColor Yellow
Write-Host "1. Make sure SQL Server is running" -ForegroundColor White
Write-Host "2. Run Database\Script.sql in SSMS to create database" -ForegroundColor White
Write-Host "3. Update App.config with correct SQL Server name" -ForegroundColor White
Write-Host "4. Run the application (F5 in Visual Studio)" -ForegroundColor White
Write-Host ""



