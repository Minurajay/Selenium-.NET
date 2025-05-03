using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;
        private readonly By _cartItems = By.ClassName("cart_item");
        private readonly By _checkoutButton = By.Id("checkout");
        private readonly By _removeButtons = By.ClassName("cart_button");

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsPageLoaded()
        {
            return _driver.FindElements(_cartItems).Any();
        }

        public int GetCartItemCount()
        {
            return _driver.FindElements(_cartItems).Count;
        }

        public List<string> GetCartItemNames()
        {
            return _driver.FindElements(By.ClassName("inventory_item_name")).Select(e => e.Text).ToList();
        }

        public void RemoveItemFromCart(int index)
        {
            _driver.FindElements(_removeButtons)[index].Click();
        }

        public CheckoutInfoPage GoToCheckout()
        {
            _driver.FindElement(_checkoutButton).Click();
            return new CheckoutInfoPage(_driver);
        }
    }
}
