﻿using OpenQA.Selenium; // telling VS that we are using Selenium here
using OpenQA.Selenium.Chrome; // telling VS that we are using Selenium chrome driver

// open chrome browser

IWebDriver driverName = new ChromeDriver();
//IWebDriver is a driver
//driverName is the name of the browser
//I am essentially telling here that my instance of webDriver is a chrome driver
driverName.Manage().Window.Maximize();

// launch turn up portal

driverName.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

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
Thread.Sleep(2000);

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

//create new time record


//navigate to time and material
IWebElement adminButton = driverName.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminButton.Click();

IWebElement tmButton = driverName.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmButton.Click();

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

//edit an existing record

//click on edit button
IWebElement editButton = driverName.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[7]/td[last()]/a[1]"));
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

//Deleting an existing record

//click on delete button