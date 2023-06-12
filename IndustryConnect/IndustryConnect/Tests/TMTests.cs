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
    public class TMTests : CommonDrivers
    {
        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginSteps(driver);

            //home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.goToTMPage(driver);
        }

        [Test]
        public void CreateTM_Test()
        {
            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();

            //create records
            tMPageObj.CreateTM(driver);
        }

        [Test]
        public void EditTM_Test()
        {
            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();

            //edit records
            tMPageObj.EditTM(driver);
        }

        [Test]
        public void DeleteTM_Test()
        {
            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();

            //delete records
            tMPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }


     }
}
