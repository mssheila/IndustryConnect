using IndustryConnect_v2.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IndustryConnect_v2.Utilities;
using OpenQA.Selenium.DevTools.V128.ServiceWorker;

namespace IndustryConnect_v2.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TMTests : CommonDrivers
    {
        //LoginPage initialisation and definition
        LoginPage loginPageObj = new LoginPage();

        //HomePage initialisation and definition
        HomePage homePageObj = new HomePage();

        //TMPage initialisation and definition
        TMpage tmPageObj = new TMpage();

        [SetUp]
        public void LoginActions()
        {
            driverName = new ChromeDriver();
            driverName.Manage().Window.Maximize();

            loginPageObj.LoginSteps(driverName);

            homePageObj.GoToTMPage(driverName);
        }

        [Test, Order(1), Description ("This is testing if a user is able to create a new record")]
        public void CreateTM_Test()
        {
            //Create new time and material records
            tmPageObj.CreateTM();
        }

        [Test, Order(2), Description("This is testing if a user is able to edit the latest record created")]
        public void EditTM_Test()
        {
            //edit time and material records
            tmPageObj.EditTM();
        }

        [Test, Order(3), Description("This is testing if a user is able to delete the latest record edited")]
        public void DeleteTM_Test()
        {
            //delete time and material records
            tmPageObj.DeleteTM();
        }

        [TearDown]
        public void CloseTestRun()
        {
            //this will close everything
            driverName.Quit();
        }        
        
    }
}
