// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox, enter valid username
driver.FindElement(By.Id("UserName")).SendKeys("hari");

//identify password textbox, enter valid password
driver.FindElement(By.Id("Password")).SendKeys("123123");


//identify login button and click

driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

Thread.Sleep(1000);

//check if user logged in successfully

IWebElement webElement = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (webElement.Text == "Hello hari!")
{
    Console.WriteLine("logged in successfully,test passed.");
}
else
{
    Console.WriteLine("logged in failed, test failed.");
}

////click on Administration button
driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

//select Time and Meterial from drop down list
driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a")).Click();

//click on create new button
driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

//select Meterial from Typecode drop down
driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));

//identify the Code box and input a code
driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("Code1");

//identify the Description box and input a code
driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("First Record");

//identify the Price per unit and input a code
driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
driver.FindElement(By.Id("Price")).SendKeys("22");

//click on save button
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(1500);

//Click on Go to the Lat Page 
driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
Thread.Sleep(2000);

//Check if Meterial record created
IWebElement Newcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (Newcode.Text == "Code1")
{
    Console.WriteLine("New meterial record created successfull,Test Passed");
}
else
{
    Console.WriteLine("New meterial record has not been Created, Test Failed");
}



////click on Administration button
IWebElement admTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
admTab.Click();

//select Time and Meterial from drop down list
IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();

//click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewButton.Click();

//select time from Typecode drop down
IWebElement dropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
dropDown.Click();
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));

//identify the Code box and input a code
IWebElement CodeBox = driver.FindElement(By.XPath("//*[@id='Code']"));
CodeBox.SendKeys("TimeCode1");

//identify the Description box and input a code
IWebElement descriptionBox = driver.FindElement(By.XPath("//*[@id='Description']"));
descriptionBox.SendKeys("First Time Record ");

//identify the Price per unit and input a code
IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceInputTag.Click();
IWebElement pricePerUnit = driver.FindElement(By.Id("Price"));
pricePerUnit.SendKeys("23");

//click on save button
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(1500);

//Click on Go to the Lat Page 
driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
Thread.Sleep(2000);

//Check if Time record created
IWebElement newTimeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newTimeCode.Text == "TimeCode1")
{
    Console.WriteLine("New time record created successfull,Test Passed");
}
else
{
    Console.WriteLine("New time record has not been Created, Test Failed");
}









