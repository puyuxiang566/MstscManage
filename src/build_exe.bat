@echo off
echo ==========================================
echo      Compiling Windows Forms App...
echo ==========================================

set MSBUILD="C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

%MSBUILD% .\MstscManage.csproj /p:Configuration=Release > build_msbuild.log 2>&1
set BUILD_EXIT_CODE=%errorlevel%

if %BUILD_EXIT_CODE% neq 0 (
    echo ==========================================
    echo   Build failed!
    echo ==========================================
    type build_msbuild.log
    pause
    exit /b 1
)

echo ==========================================
echo Build succeeded!
echo ==========================================
pause
