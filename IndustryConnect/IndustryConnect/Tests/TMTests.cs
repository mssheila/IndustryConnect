using IndustryConnect.Pages;
using NUnit.Framework;
using IndustryConnect.Utilities;
using OpenQA.Selenium;

namespace IndustryConnect.Tests
{
    [TestFixture]
    //[Parallelizable]
    public class TMTests : CommonDrivers
    {
        HomePage homePageObj = new HomePage();
        TMPage tMPageObj = new TMPage();

        [Test, Order(1), Description("This is to test TM creation")]
        public void CreateTM_Test(IWebDriver driver)
        {
            homePageObj.goToTMPage(driver);
            tMPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("This is to test the edit function for TM")]
        public void EditTM_Test(IWebDriver driver)
        {
            homePageObj.goToTMPage(driver);
            //tMPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("This is to test the delete function for TM")]
        public void DeleteTM_Test()
        {
            homePageObj.goToTMPage(driver);
            tMPageObj.DeleteTM(driver);
        }

     }
}
