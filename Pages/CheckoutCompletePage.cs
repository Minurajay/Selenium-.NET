using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class CheckoutCompletePage
    {
        private readonly IWebDriver _driver;
        private readonly By _thankYouMessage = By.ClassName("complete-header");
        private readonly By _backToProductsButton = By.Id("back-to-products");

        public CheckoutCompletePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsOrderCompleted()
        {
            return _driver.FindElements(_thankYouMessage).Count > 0;
        }

        public string GetThankYouMessage()
        {
            return _driver.FindElement(_thankYouMessage).Text;
        }

        public InventoryPage BackToProducts()
        {
            _driver.FindElement(_backToProductsButton).Click();
            return new InventoryPage(_driver);
        }
    }
}
