using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

//open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
Thread.Sleep(1000);

//check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!") 
{
    Console.WriteLine("User has logged in successfully");
} 
else 
{
    Console.WriteLine("User login failed");
}

//create new time record
//navigate to time and material module
IWebElement AdminDropDown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
AdminDropDown.Click();

IWebElement TimeNmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TimeNmaterial.Click();

//click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

//select time option from dropdown
IWebElement tmDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
tmDropDown.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();

//type code into code textbox
IWebElement codeTxtbox = driver.FindElement(By.Id("Code"));
codeTxtbox.SendKeys(("Test code"));

//type description into description textbox
IWebElement descriptionTxtbox = driver.FindElement(By.Id("Description"));
descriptionTxtbox.SendKeys(("Test description"));

//type price into price per unit textbox
IWebElement blocker = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
blocker.Click();
IWebElement priceTxtbox = driver.FindElement(By.Id("Price"));
priceTxtbox.SendKeys("12");


//click on save button
IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
saveButton.Click();
Thread.Sleep(3000);

//check if new time record has been created successfully
IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPageButton.Click();

IWebElement TestCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
IWebElement TestDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
IWebElement TestPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[last()]"));

if (TestCode.Text == "Test code") //&& TestDescription.Text == "Test description" && TestPrice.Text == "12.00")
{
    Console.WriteLine("save was successful");
}
else 
{
    Console.WriteLine("save UNSUCCESSFUL");
}