﻿using IndustryConnect.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IndustryConnect.Pages
{
    public class HomePage
    {
        public void goToTMPage(IWebDriver driver)
        {
            //create new time record
            //navigate to time and material module
            driver = new ChromeDriver();
            IWebElement AdminDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
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
