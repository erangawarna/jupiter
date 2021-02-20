using JupiterToys.Utils;
using OpenQA.Selenium;

namespace JupiterToys.PageObjects
{
    // Top header panel considered as a part of home page instead of having another page objetc
    public class HomePage : BaseClass
    {
        By lnkHome = By.Id("nav-home");
        By lnkContact = By.Id("nav-contact");
        By lnkShop = By.Id("nav-shop");
        By lnkCart = By.Id("nav-cart");

        public HomePage(IWebDriver Driver)
        {
            driver = Driver;
        }

        public void NavigateToHomePage()
        {
            Click(lnkHome);
        }

        public void NavigateToContactPage()
        {
            Click(lnkContact);
        }

        public void NavigateToShopPage()
        {
            Click(lnkShop);
        }

        public void NavigateToCart()
        {
            Click(lnkCart);
        }
    }
}
