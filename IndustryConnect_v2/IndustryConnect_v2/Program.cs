using OpenQA.Selenium; // telling VS that we are using Selenium here
using OpenQA.Selenium.Chrome; // telling VS that we are using Selenium chrome driver

// open chrome browser

IWebDriver driverName = new ChromeDriver();
//IWebDriver is a driver
//driverName is the name of the browser
//I am essentially telling here that my instance of webDriver is a chrome driver
driverName.Manage().Window.Maximize();

// launch turn up portal

driverName.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify username textbox and enter valid username

IWebElement usernameTextbox = driverName.FindElement(By.Id("UserName"));
//IWebElement is basically telling selenium I am adding an element
//driveName.FindElement is asking the browser to find an element for me

usernameTextbox.SendKeys("hari");

// identify password textbox and enter valid password

IWebElement passwordTextbox = driverName.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// identify login button and click on it
IWebElement loginButton = driverName.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check if user has logged in successfully
IWebElement helloHari = driverName.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
    //helloHari.Text is asking to read only the text of the element
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User login failed");
}