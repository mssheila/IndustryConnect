﻿using OpenQA.Selenium;

namespace IndustryConnect_v2.Pages
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driverName)
        {
            //click on create new button
            IWebElement createNewButton = driverName.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //select time option in the dropdown
            IWebElement dropdown = driverName.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            dropdown.Click();

            IWebElement timeOption = driverName.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //type code into code textbox
            IWebElement codeTextBox = driverName.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Sheila1");

            //type description into description textbox
            IWebElement desTextBox = driverName.FindElement(By.Id("Description"));
            desTextBox.SendKeys("Sheila Description 1");

            //type price into price per unit textbox
            IWebElement priceTextBox = driverName.FindElement(By.Id("Price"));
            IWebElement textBoxBlocker = driverName.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            textBoxBlocker.Click(); //this is to by pass the element that is blocking the textbox
            priceTextBox.SendKeys("1.11");

            //click on save button
            IWebElement saveButton = driverName.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if new time record has been created successfully
            IWebElement lastPageBtn = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageBtn.Click();

            IWebElement newCode = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "Sheila1")
            {
                Console.WriteLine("New record successfully created");
            }
            else
            {
                Console.WriteLine("No new record created");
            }
        }

        public void EditTM(IWebDriver driverName)
        {
            //click on edit button
            IWebElement editButton = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3000);

            //edit description
            IWebElement desTextBoxEdit = driverName.FindElement(By.Id("Description"));
            desTextBoxEdit.Clear();
            desTextBoxEdit.SendKeys("Sheila Description Edited");

            //save
            IWebElement saveButtonEdit = driverName.FindElement(By.Id("SaveButton"));
            saveButtonEdit.Click();
            Thread.Sleep(3000);

            //verify that record was successfully edited
            IWebElement lastPageBtnEdit = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageBtnEdit.Click();

            IWebElement newDescription = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            if (newDescription.Text == "Sheila Description Edited")
            {
                Console.WriteLine("New record successfully UPDATED");
            }
            else
            {
                Console.WriteLine("Record NOT updated");
            }

        }

        public void DeleteTM(IWebDriver driverName)
        {
            Thread.Sleep(3000);

            //click on delete button
            IWebElement deleteButton = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            //click ok on alert
            IAlert deleteAlert = driverName.SwitchTo().Alert();
            deleteAlert.Accept();

            Thread.Sleep(3000);

            //verify that record was successfully deleted
            IWebElement lastPageBtnDelete = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageBtnDelete.Click();

            IWebElement delDescription = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            if (delDescription.Text == "Sheila Description Edited")
            {
                Console.WriteLine("Record is still there");
            }
            else
            {
                Console.WriteLine("Record successfully DELETED");
            }
        }
    }
}