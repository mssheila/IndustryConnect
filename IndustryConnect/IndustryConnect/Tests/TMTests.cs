using IndustryConnect.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

//open chrome browser
IWebDriver driver = new ChromeDriver();

//login page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.loginSteps(driver);

//home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.goToTMPage(driver);

//TM page object initialization and definition
TMPage tMPageObj = new TMPage();

//create records
tMPageObj.CreateTM(driver);

//edit records
tMPageObj.EditTM(driver);

//delete records
tMPageObj.DeleteTM(driver);

