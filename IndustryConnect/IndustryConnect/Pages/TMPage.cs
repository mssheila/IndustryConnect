using OpenQA.Selenium;


namespace IndustryConnect.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
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
        }

        public void EditTM(IWebDriver driver)
        {
            //code for edit TM record
        }

        public void DeleteTM(IWebDriver driver) 
        {
            //code for delete TM record
        }

    }
}
