using OpenQA.Selenium;

namespace IndustryConnect_v2.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driverName)
        {
            //navigate to time and material
            IWebElement adminButton = driverName.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminButton.Click();

            IWebElement tmButton = driverName.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmButton.Click();
        }
    }
}
