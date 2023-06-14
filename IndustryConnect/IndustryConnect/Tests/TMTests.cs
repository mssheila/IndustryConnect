using IndustryConnect.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IndustryConnect.Utilities;
using OpenQA.Selenium.Chrome;

namespace IndustryConnect.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TMTests : CommonDrivers
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        //TM page object initialization and definition
        TMPage tMPageObj = new TMPage();

        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition
            loginPageObj.loginSteps();

            //home page object initialization and definition
            homePageObj.goToTMPage();
        }

        [Test, Order(1), Description("This is to test TM creation")]
        public void CreateTM_Test()
        {
            //create records
            tMPageObj.CreateTM();
        }

        [Test, Order(2), Description("This is to test the edit function for TM")]
        public void EditTM_Test()
        {
            //edit records
            tMPageObj.EditTM();
        }

        [Test, Order(3), Description("This is to test the delete function for TM")]
        public void DeleteTM_Test()
        {
            //delete records
            tMPageObj.DeleteTM();
        }

        [TearDown]
        public void CloseTestRun()
        {
            tMPageObj.QuitBrowser();
        }


     }
}
