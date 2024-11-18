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

namespace IndustryConnect_v2.Tests
{
    [TestFixture]
    public class TMTests : CommonDrivers
    {
        [SetUp]
        public void LoginActions()
        {
            driverName = new ChromeDriver();
            driverName.Manage().Window.Maximize();

            //LoginPage initialisation and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driverName);

            //HomePage initialisation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driverName);
        }

        [Test]
        public void CreateTM_Test()
        {
            //TMPage object initialisation and definition
            TMpage tmPageObj = new TMpage();
            //Create new time and material records
            tmPageObj.CreateTM(driverName);
        }

        [Test]
        public void EditTM_Test()
        {
            //TMPage object initialisation and definition
            TMpage tmPageObj = new TMpage();
            //edit time and material records
            tmPageObj.EditTM(driverName);
        }

        [Test]
        public void DeleteTM_Test()
        {
            //TMPage object initialisation and definition
            TMpage tmPageObj = new TMpage();
            //delete time and material records
            tmPageObj.DeleteTM(driverName);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }        
        
    }
}
