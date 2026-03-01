# Script para restaurar, compilar e executar o projeto SoftwareLojasRibeiro
# Build and Run Script for SoftwareLojasRibeiro

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  Software Lojas Ribeiro - Build & Run" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Passo 1: Verificar se o nuget.exe existe, senao baixar
Write-Host "[1/4] Verificando NuGet..." -ForegroundColor Yellow
if (-Not (Test-Path "nuget.exe")) {
    Write-Host "      Baixando nuget.exe..." -ForegroundColor Gray
    Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile "nuget.exe"
    Write-Host "      OK - NuGet baixado com sucesso" -ForegroundColor Green
} else {
    Write-Host "      OK - NuGet ja existe" -ForegroundColor Green
}
Write-Host ""

# Passo 2: Restaurar pacotes NuGet
Write-Host "[2/4] Restaurando pacotes NuGet..." -ForegroundColor Yellow
.\nuget.exe restore SoftwareLojasRibeiro.sln -NonInteractive
if ($LASTEXITCODE -eq 0) {
    Write-Host "      OK - Pacotes restaurados com sucesso" -ForegroundColor Green
} else {
    Write-Host "      ERRO - Erro ao restaurar pacotes" -ForegroundColor Red
    exit 1
}
Write-Host ""

# Passo 3: Compilar o projeto
Write-Host "[3/4] Compilando o projeto..." -ForegroundColor Yellow
$msbuildPath = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"

if (Test-Path $msbuildPath) {
    & $msbuildPath "SoftwareLojasRibeiro\SoftwareLojasRibeiro.csproj" /p:Configuration=Debug /t:Build /v:minimal
} else {
    Write-Host "      MSBuild do Visual Studio nao encontrado, tentando com dotnet..." -ForegroundColor Gray
    dotnet build SoftwareLojasRibeiro\SoftwareLojasRibeiro.csproj -c Debug
}

if ($LASTEXITCODE -eq 0) {
    Write-Host "      OK - Projeto compilado com sucesso" -ForegroundColor Green
} else {
    Write-Host "      ERRO - Erro ao compilar o projeto" -ForegroundColor Red
    exit 1
}
Write-Host ""

# Passo 4: Executar a aplicacao
Write-Host "[4/4] Iniciando aplicacao..." -ForegroundColor Yellow
Write-Host ""
Start-Process "SoftwareLojasRibeiro\bin\Debug\SoftwareLojasRibeiro.exe"
Write-Host "      OK - Aplicacao iniciada!" -ForegroundColor Green
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  Aplicacao em execucao!" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
