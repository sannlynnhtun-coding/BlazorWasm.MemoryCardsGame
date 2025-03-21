
@echo off
REM ===========================
REM Title: Deploy .NET Project to Vercel
REM Description: This batch file navigates to the project folder, builds the project with a custom output path, and deploys to Vercel.
REM ===========================

REM Navigate to the project folder
cd "D:\slh\proj\BlazorWasm.MemoryCardsGame\BlazorWasm.MemoryCardsGameV2"

REM Build the project with custom output path
dotnet publish -c Release

cd "D:\slh\proj\BlazorWasm.MemoryCardsGame\BlazorWasm.MemoryCardsGameV2\bin\Release\net8.0\browser-wasm\publish"

REM Deploy to Vercel
vercel --prod