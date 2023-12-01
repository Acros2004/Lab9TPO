using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSecond.Pages;

namespace TestSecond.Tests
{
    public class KufarTests
    {
        [Test]
        public void TestAddItemToBasket()
        {
            HomePage kufarPage = new HomePage(new ChromeDriver());
            kufarPage.GoToPage();
            kufarPage.ClosingPolicyAndAdvertisingWindows();
            kufarPage.GoToProductPage();
            Assert.IsTrue(kufarPage.GetPageTitle() == "Открытки поздравительные. Двойные, цена 3 р. купить в Минске на Куфаре - Объявление №214160074");
            Thread.Sleep(3000);
            kufarPage.ClickLikeButton();
            kufarPage.LoginToAccount();
            kufarPage.ClickFavorites();
            kufarPage.ClickFavoriteProduct();
            Assert.IsTrue(kufarPage.GetPageTitle() == "Открытки поздравительные. Двойные, цена 3 р. купить в Минске на Куфаре - Объявление №214160074");
            kufarPage.Exit();
        }

        [Test]
        public void DisplayingProductsByCategoryAndBySpecificRegion()
        {
            HomePage kufarPage = new HomePage(new ChromeDriver());
            kufarPage.GoToPage();
            kufarPage.ClosingPolicyAndAdvertisingWindows();
            kufarPage.GoToPage();
            kufarPage.ChangeRegionToGrodno();
            kufarPage.InputSomeProductInSearch();
            kufarPage.ClickProduct();
            Assert.IsTrue(kufarPage.GetRegionOfProductPage() == "Гродненская, Гродно");
            kufarPage.Exit();
        }
    }
}
