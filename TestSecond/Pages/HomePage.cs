using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSecond.Pages
{
    public class HomePage : AbstractPage
    {
        private string url = "https://www.kufar.by/l/r~minsk";
        private string urlProduct = "https://www.kufar.by/item/214160074?rank=3&searchId=dd7c208fce5bf1dbf87d02e2b655c6a7744d";
        public HomePage(IWebDriver webDriver) : base(webDriver) { }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClosingPolicyAndAdvertisingWindows()
        {
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div[2]/button")).Click();
        }
        public void GoToProductPage()
        {
            driver.Navigate().GoToUrl(urlProduct);
        }
        public void ClickLikeButton()
        {
            driver.FindElement(By.XPath("//*[@id=\"adview_content\"]/div[1]/div[2]/div[2]/div")).Click();
            Thread.Sleep(5000);
        }
        public void LoginToAccount()
        {
            driver.FindElement(By.XPath("//*[@id=\"login\"]")).SendKeys("nikn53275@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("nikitaA_z2004");
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[3]/div/div/form/div[4]/button")).Click();
            Thread.Sleep(5000);
        }
        public void ClickFavorites()
        {
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[2]/div[1]")).Click();
            Thread.Sleep(4000);
        }
        public void ClickFavoriteProduct()
        {
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/div/div[2]/div[1]/div[2]/div[2]/div[2]/div/a[1]/div[1]/div/div[2]")).Click();
            string parentWindowHandle = driver.CurrentWindowHandle;
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle != parentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
        }
        public void ChangeRegionToGrodno()
        {
            
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[3]/div/button")).Click();
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[3]/div/div/div/div[1]/div/select")).Click();
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[3]/div/div/div/div[1]/div/select/option[5]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[3]/div/div/div/div[2]/div/select")).Click();
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[3]/div/div/div/div[2]/div/select/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);
        }
        public void InputSomeProductInSearch()
        {
            Thread.Sleep(11000);
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[2]/div/div/div/div/input")).Click();
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[2]/div/div[1]/div/div/input")).SendKeys("дом");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[1]/div[2]/div/div[1]/div/div/button[2]")).Click();
            
        }

        public void ClickProduct()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div[4]/div[1]/div/div/div[2]/div/div/section[1]/a/div[1]/div/div[2]")).Click();
            Thread.Sleep(3000);
            string parentWindowHandle = driver.CurrentWindowHandle;
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle != parentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
        }
        public string GetRegionOfProductPage()
        {
            IWebElement spanElement = driver.FindElement(By.XPath("//*[@id=\"adview_content\"]/div[2]/div[1]/span[1]"));
            return spanElement.Text;
        }


    }
}
