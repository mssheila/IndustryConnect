using IndustryConnect.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IndustryConnect.Utilities
{
    public class CommonDrivers
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginSteps(driver);
        }


        [OneTimeTearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}

