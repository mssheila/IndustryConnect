using OpenQA.Selenium;

namespace IndustryConnect.Pages
{
    public class HomePage
    {
        public void goToTMPage(IWebDriver driver)
        {
            //create new time record
            //navigate to time and material module
            IWebElement AdminDropDown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            AdminDropDown.Click();

            IWebElement TimeNmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeNmaterial.Click();
        }
    }
}
