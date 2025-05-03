using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class CheckoutInfoPage
    {
        private readonly IWebDriver _driver;
        private readonly By _firstNameField = By.Id("first-name");
        private readonly By _lastNameField = By.Id("last-name");
        private readonly By _postalCodeField = By.Id("postal-code");
        private readonly By _continueButton = By.Id("continue");

        public CheckoutInfoPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsPageLoaded()
        {
            return _driver.FindElements(_firstNameField).Count > 0;
        }

        public CheckoutOverviewPage FillCheckoutInfo(string firstName, string lastName, string zipCode)
        {
            _driver.FindElement(_firstNameField).SendKeys(firstName);
            _driver.FindElement(_lastNameField).SendKeys(lastName);
            _driver.FindElement(_postalCodeField).SendKeys(zipCode);
            _driver.FindElement(_continueButton).Click();
            return new CheckoutOverviewPage(_driver);
        }
    }
}
