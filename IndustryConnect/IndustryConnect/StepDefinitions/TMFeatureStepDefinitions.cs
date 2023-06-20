using IndustryConnect.Pages;
using IndustryConnect.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IndustryConnect.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDrivers
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            //driver = new ChromeDriver();

            //login turn up portal
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginSteps(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.goToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();

            //create records
            tMPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();

            string newCode = tMPageObj.GetCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.That(newCode == "Test code", "Actual Result Code differs from Expected Result");
            Assert.That(newDescription == "Test description", "Actual Result Description differs from Expected Result");
            Assert.That(newPrice == "$12.00", "Actual Result Price differs from Expected Result");
        }

        [When(@"I update '([^']*)' edit an existing time and material record")]
        public void WhenIUpdateEditAnExistingTimeAndMaterialRecord(string description)
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver, description);
        }

        [Then(@"The record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description)
        {
            
        }

    }
}
