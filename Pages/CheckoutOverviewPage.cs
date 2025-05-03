using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1.Pages
{
    public class CheckoutOverviewPage
    {
        private readonly IWebDriver _driver;
        private readonly By _cartItems = By.ClassName("cart_item");
        private readonly By _subtotalLabel = By.ClassName("summary_subtotal_label");
        private readonly By _taxLabel = By.ClassName("summary_tax_label");
        private readonly By _totalLabel = By.ClassName("summary_total_label");
        private readonly By _finishButton = By.Id("finish");

        public CheckoutOverviewPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsPageLoaded()
        {
            return _driver.FindElements(_cartItems).Any();
        }

        public List<string> GetCartItemNames()
        {
            return _driver.FindElements(By.ClassName("inventory_item_name")).Select(e => e.Text).ToList();
        }

        public double GetSubtotal()
        {
            var text = _driver.FindElement(_subtotalLabel).Text;
            return double.Parse(text.Replace("Item total: $", ""));
        }

        public double GetTax()
        {
            var text = _driver.FindElement(_taxLabel).Text;
            return double.Parse(text.Replace("Tax: $", ""));
        }

        public double GetTotal()
        {
            var text = _driver.FindElement(_totalLabel).Text;
            return double.Parse(text.Replace("Total: $", ""));
        }

        public CheckoutCompletePage FinishCheckout()
        {
            _driver.FindElement(_finishButton).Click();
            return new CheckoutCompletePage(_driver);
        }
    }
}
