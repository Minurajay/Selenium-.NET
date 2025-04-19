using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        private IWebDriver driver1;  // Class-level WebDriver instance

        [TestInitialize]  // This runs before each test
        public void Setup()
        {
            driver1 = new ChromeDriver();
            driver1.Manage().Window.Maximize(); // Optional: Maximize browser window
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver1.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Use WebDriverWait to wait for the login button
            var wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));

            // Locate the correct login button using ID instead of class
            IWebElement loginButton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));

            Assert.IsTrue(loginButton.Displayed, "Login button is not displayed.");

            var userNamefield = driver1.FindElement(By.Id("user-name"));
            userNamefield.SendKeys("standard_user");
            var passwordField = driver1.FindElement(By.Id("password"));
            passwordField.SendKeys("secret_sauce");
            loginButton.Click();

            Assert.IsTrue(driver1.Url.Contains("inventory.html"), "Login failed.");
        }

        [TestCleanup]  // This runs after each test
        public void Cleanup()
        {
            Thread.Sleep(1000);  // Optional: Wait 1 second before closing the browser
            driver1.Quit();  // Ensures browser closes after the test
        }
    }
}
