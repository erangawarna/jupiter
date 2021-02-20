using JupiterToys.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace JupiterToys.PageObjects
{
    public class CartPage : BaseClass
    {
        By lnkCart = By.Id("nav-cart");
        By rowItem = By.ClassName("cart-item");

        public CartPage(IWebDriver Driver)
        {
            driver = Driver;
        }

        public void VerifyAddedItemCount()
        {
            string[] cartText = GetText(lnkCart).Split(new char[] { '(', ')' });
            Assert.AreEqual(ShopPage.totalItems.ToString(), cartText[1]);
        }

        public void VerifyCartItems(int times, string itemName)
        {
            var itemCount = GetCount(rowItem);
            int i = 1;
            while (i < itemCount + 1)
            {
                if (GetText(By.XPath("//tr[" + i + "]/td[1]")) == itemName)
                {
                    Assert.AreEqual(times.ToString(), GetAttribute(By.XPath("//tr[" + i + "]/td[3]/input"), "value"));
                    i = itemCount;
                }
                i++;
            }
        }
    }
}
