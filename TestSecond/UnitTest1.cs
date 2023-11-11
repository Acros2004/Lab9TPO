using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text;

namespace TestSecond
{
    public class Tests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.kufar.by/l/r~minsk";
            verificationErrors = new StringBuilder();

        }

        [TearDown]
        public void TearDownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Assert.That(verificationErrors.ToString(), Is.EqualTo(""));
        }

        [Test]
        public void TestAddItemToBasket()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div[2]/button")).Click();
            driver.Navigate().GoToUrl("https://www.kufar.by/item/214160074?rank=3&searchId=dd7c208fce5bf1dbf87d02e2b655c6a7744d");
            //driver.FindElement(By.ClassName("styles_crossIcon__usfo0")).Click();
            /*driver.FindElement(By.ClassName("styles_input__4pYpl")).SendKeys("дом");
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("styles_search_button__HMLQM")).Click();
            Thread.Sleep(5000);
            string parentWindowHandle = driver.CurrentWindowHandle;
            driver.FindElements(By.ClassName("styles_image__QXHZP")).First().Click();
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle != parentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }*/

            Assert.That(driver.Title, Is.EqualTo("Открытки поздравительные. Двойные, цена 3 р. купить в Минске на Куфаре - Объявление №214160074"));
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"adview_content\"]/div[1]/div[2]/div[2]/div")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"login\"]")).SendKeys("nikn53275@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("nikitaA_z2004");
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[3]/div/div/form/div[4]/button")).Click();
            Thread.Sleep(5000);    
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div[2]/div[1]")).Click();
            Thread.Sleep(4000);
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
            Assert.That(driver.Title, Is.EqualTo("Открытки поздравительные. Двойные, цена 3 р. купить в Минске на Куфаре - Объявление №214160074"));
        }
    }
}