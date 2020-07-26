# Payroll Tax Application Solution

This application allows for individual or family to calculate the year-end income tax owed if they are a work commuter in the UT-CA-NV tri-state area. The goal is to allow the individual or family to get an estimate of all taxes owed while accounting for each state's tax rules (e.g. CA has one of the highest tax rates, while NV has no state income tax)

## Installations

- [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/)
- MS Access dependencies installed

## Instructions

- Download the VS `PayrollTaxCalculator` solution folder and the `PayRollTaxCalculator.sln` file
- Download the MS Access database file `TaxUsers.accdb`
- **Reference Files** You can download `User Manual` and any of the pdf files for reference on the tax rules applied when building the application
- In Visual Studio, add a solution and load the `PayrollTaxCalculator` folder and sln file, and the database file
- Once loaded, open and run `Form_Main.cs` in the project folder
- The different tabs will show instructions and links for how to proceed to sign up, login, and use the tax calculator

### Potential Issues
There is now [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/). This project has not been refactored to investigate any dependencies that might result from the newer version of the IDE.
