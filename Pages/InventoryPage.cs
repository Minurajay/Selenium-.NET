using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1.Pages
{
    public class InventoryPage
    {
        private readonly IWebDriver _driver;
        private readonly By _productNames = By.ClassName("inventory_item_name");
        private readonly By _productPrices = By.ClassName("inventory_item_price");
        private readonly By _addToCartButtons = By.ClassName("btn_inventory");
        private readonly By _cartBadge = By.ClassName("shopping_cart_badge");
        private readonly By _cartLink = By.ClassName("shopping_cart_link");

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsPageLoaded()
        {
            return _driver.FindElements(_productNames).Any();
        }

        public List<string> GetProductNames()
        {
            return _driver.FindElements(_productNames).Select(e => e.Text).ToList();
        }

        public List<double> GetProductPrices()
        {
            return _driver.FindElements(_productPrices).Select(e => double.Parse(e.Text.Trim('$'))).ToList();
        }

        public void AddProductToCart(int index)
        {
            _driver.FindElements(_addToCartButtons)[index].Click();
        }

        public int GetCartItemCount()
        {
            var badge = _driver.FindElements(_cartBadge).FirstOrDefault();
            return badge != null ? int.Parse(badge.Text) : 0;
        }

        public CartPage GoToCart()
        {
            _driver.FindElement(_cartLink).Click();
            return new CartPage(_driver);
        }
    }
}
