using IndustryConnect_v2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace IndustryConnect_v2.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driverName)
        {
            // launch turn up portal

            driverName.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Wait.WaitToBeVisible(driverName, "Id", "UserName", 10);

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
            Wait.WaitForElement(driverName, "XPath", "//*[@id=\"logoutForm\"]/ul/li/a", 10);

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

        }
    }
}
