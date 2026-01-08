# PowerShell script to find SQL Server instances
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Finding SQL Server Instances..." -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Method 1: Check SQL Server services
Write-Host "Method 1: Checking SQL Server Services" -ForegroundColor Yellow
Write-Host "----------------------------------------" -ForegroundColor Yellow
$services = Get-Service | Where-Object { $_.Name -like "*SQL*" -and $_.Status -eq "Running" }
if ($services) {
    foreach ($service in $services) {
        Write-Host "Found: $($service.Name) - $($service.DisplayName)" -ForegroundColor Green
        if ($service.Name -eq "MSSQLSERVER") {
            Write-Host "  → Use: localhost or . (dot)" -ForegroundColor Cyan
        }
        elseif ($service.Name -like "MSSQL$*") {
            $instance = $service.Name -replace "MSSQL\$", ""
            Write-Host "  → Use: localhost\$instance or .\$instance" -ForegroundColor Cyan
        }
    }
} else {
    Write-Host "No SQL Server services found running!" -ForegroundColor Red
}
Write-Host ""

# Method 2: Try to query SQL Server
Write-Host "Method 2: Testing Common Connection Strings" -ForegroundColor Yellow
Write-Host "----------------------------------------" -ForegroundColor Yellow

$testConnections = @(
    "localhost",
    "localhost\SQLEXPRESS",
    ".\SQLEXPRESS",
    ".",
    "$env:COMPUTERNAME",
    "$env:COMPUTERNAME\SQLEXPRESS"
)

foreach ($server in $testConnections) {
    try {
        $connection = New-Object System.Data.SqlClient.SqlConnection("Server=$server;Integrated Security=True;Connection Timeout=3;TrustServerCertificate=True")
        $connection.Open()
        $connection.Close()
        Write-Host "✓ SUCCESS: $server" -ForegroundColor Green
        Write-Host "  → Update App.config with: Data Source=$server" -ForegroundColor Cyan
    }
    catch {
        Write-Host "✗ Failed: $server" -ForegroundColor Gray
    }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Instructions:" -ForegroundColor Cyan
Write-Host "1. Copy one of the SUCCESS connection strings above" -ForegroundColor White
Write-Host "2. Open App.config in your project" -ForegroundColor White
Write-Host "3. Replace 'localhost' with the server name that worked" -ForegroundColor White
Write-Host "========================================" -ForegroundColor Cyan



