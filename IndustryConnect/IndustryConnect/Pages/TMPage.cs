using IndustryConnect.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IndustryConnect.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //below is implicit wait. Selenium will wait up to 7 secs for all "driver" variables. Will continue to next code if found the elements earlier.
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));

            //below is explicit wait.
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
            //wait.Until(ExpectedConditions.ElementExists(By.Id(Id)));

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
            Thread.Sleep(1000);

            
            
            //try
            //{
            
            //}
            //catch(Exception e)
            //{
            //    Assert.Fail("Cannot find price element", e.Message);
            //}

            //Assert.That(TestCode.Text == "Test code", "Actual Result Code differs from Expected Result");
            //Assert.That(TestDescription.Text == "Test description", "Actual Result Description differs from Expected Result");
            //Assert.That(TestPrice.Text == "$12.00", "Actual Result Price differs from Expected Result");

            //if (TestCode.Text == "Test code") //&& TestDescription.Text == "Test description" && TestPrice.Text == "12.00")
            //{
            //    Assert.Pass("save was successful");
            //}
            //else
            //{
            //    Assert.Fail("save UNSUCCESSFUL");
            //}
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }

        public void EditTM(IWebDriver driver, string description, string code, string price)
        {
            //go to last page
            Thread.Sleep(5000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement tCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (tCode.Text == "Test code")
            {
                //click edit on last record
                IWebElement editBtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editBtn.Click();
                Thread.Sleep(3000);
            }
            else
                Assert.Fail("Record to be edited not found");

            //edit description
            IWebElement descriptionTxtbox = driver.FindElement(By.Id("Description"));
            descriptionTxtbox.Clear();
            descriptionTxtbox.SendKeys(description);

            //edit code
            IWebElement codeTxtbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTxtbox.Clear();
            codeTxtbox.SendKeys(code);

            //edit price
            IWebElement priceTxtbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            priceTxtbox.Clear();
            priceTxtbox.SendKeys(price);

            //click save
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();
            Thread.Sleep(5000);

            //check if edited time description saved successfully
            lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            //IWebElement TestCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement TestDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            //try
            //{
            //    IWebElement TestPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[last()]/td[4]"));
            //}
            //catch (Exception e)
            //{
            //    Assert.Fail("Cannot find price element", e.Message);
            //}

            //Assert.That(TestCode.Text == "Test code", "Actual Result Code differs from Expected Result");
            //Assert.That(TestDescription.Text == "Sheila Edited description", "Actual Result Description differs from Expected Result");
            //Assert.That(TestPrice.Text == "$12.00", "Actual Result Price differs from Expected Result");
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedCode.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedPrice.Text;
        }

        public void DeleteTM(IWebDriver driver) 
        {
            //go to last page
            Thread.Sleep(5000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement TestDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement deleteBtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

            if (TestDescription.Text == "Sheila Edited description")
            {
                //click delete on last record
                deleteBtn.Click();
                driver.SwitchTo().Alert().Accept();
                Thread.Sleep(5000);
            }
            else
                Assert.Fail("Record to be edited not found");

            //check if last record deleted successfully
            TestDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            if (TestDescription.Text == "Sheila Edited description")
                Assert.Fail("Deletion unsuccessful");

            // Assert.That(TestDescription.Text != "Sheila Edited description", "Deletion unsuccessful");

            //IWebElement TestCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"))
            ////try
            ////{
            ////    IWebElement TestPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[last()]/td[4]"));
            ////}
            ////catch (Exception e)
            ////{
            ////    Assert.Fail("Cannot find price element", e.Message);
            ////}

            //Assert.That(TestCode.Text == "Test code", "Actual Result Code differs from Expected Result");
            //Assert.That(TestDescription.Text == "Sheila Edited description", "Actual Result Description differs from Expected Result");
            ////Assert.That(TestPrice.Text == "$12.00", "Actual Result Price differs from Expected Result");
        }

        public void QuitBrowser(IWebDriver driver)
        {
           driver.Quit();
        }
    }
}
