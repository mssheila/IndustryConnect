using IndustryConnect.Utilities;
using OpenQA.Selenium;

namespace IndustryConnect.Pages
{
    public class HomePage : CommonDrivers
    {
        public void goToTMPage()
        {
            //create new time record
            //navigate to time and material module
            IWebElement AdminDropDown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            AdminDropDown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);

            IWebElement TimeNmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeNmaterial.Click();
        }

        public void goToEmployeePage()
        {
            //code to go to employee page
        }
    }
}
