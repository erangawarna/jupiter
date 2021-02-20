using JupiterToys.Utils;
using OpenQA.Selenium;
using System;

namespace JupiterToys.PageObjects
{
    public class ShopPage : BaseClass
    {
        By pnlProducts = By.ClassName("product");

        public int totalItems;

        public ShopPage(IWebDriver Driver)
        {
            driver = Driver;
        }

        public void FindAndClickBuyForItems(int times, string itemName)
        {
            var itemCount = GetCount(pnlProducts);
            int i = 1;
            while (i < itemCount + 1)
            {
                if (GetText(By.XPath("//li[@id='product-" + i + "']/div/h4")) == itemName)
                {
                    for(int j = 1; j <= times; j++)
                    {
                        Click(By.XPath("//li[@id='product-" + i + "']/div/p/a"));
                    }
                    i = itemCount;
                }
                i++;
            }
            totalItems = totalItems + times;
        }
    }
}
