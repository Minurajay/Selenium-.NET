using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestProject1.Tests
{
    [TestClass]
    public class Test1
    {
        private IWebDriver _driver;

        public Test1()
        {
            // Initialize _driver here to avoid the warning
            _driver = new ChromeDriver(); // You can choose either Chrome or Firefox based on your needs
        }

        [TestMethod]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("https://www.example.com");
            Assert.AreEqual("Example Domain", _driver.Title);
            _driver.Quit();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver?.Quit(); // Ensure the driver is quit properly after each test
        }
    }
}
