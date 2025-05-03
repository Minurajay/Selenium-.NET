# Selenium + .NET

This is a Selenium WebDriver automation project using C#, NUnit, and the Page Object Model (POM) design pattern. It automates tests for the SauceDemo website.

## Project Structure

- **Drivers/** - WebDriver setup and browser initialization  
- **Pages/** - Page Object classes for each application page  
- **Tests/** - NUnit test classes using the page objects  
- **Utils/** - Utility classes (e.g., test data reader)  
- **appsettings.json** - Configuration like URL, browser, credentials  

## Prerequisites

- .NET SDK installed  
- Chrome or Firefox installed  
- ChromeDriver or GeckoDriver in system PATH  

## How to Run

1. Clone the project  
2. Open in Visual Studio or run via terminal  
3. Update `appsettings.json` if needed  
4. Run the tests using the Test Explorer or CLI:  
