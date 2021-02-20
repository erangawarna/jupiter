using JupiterToys.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace JupiterToys.Utils
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static string timeStamp;

        public static HomePage HomePage;
        public static ContactPage ContactPage;
        public static ShopPage ShopPage;
        public static CartPage CartPage;

        public static void Setup()
        {
            var chromeOptions = new ChromeOptions();
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://jupiter.cloud.planittesting.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            HomePage = new HomePage(driver);
            ContactPage = new ContactPage(driver);
            ShopPage = new ShopPage(driver);
            CartPage = new CartPage(driver);

            timeStamp = GetTimestamp(DateTime.Now);
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmss");
        }

        public void Click(By by)
        {
            driver.FindElement(by).Click();
        }

        public void Enter(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }

        public string GetText(By by)
        {
            return driver.FindElement(by).Text;
        }

        public string GetAttribute(By by, string att)
        {
            return driver.FindElement(by).GetAttribute(att);
        }

        public int GetCount(By by)
        {
            return driver.FindElements(by).Count;
        }

        public static void Quit()
        {
            driver.Quit();
        }
    }
}
