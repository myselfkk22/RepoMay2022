using NUnit.Framework;
using OpenQA.Selenium;
using RepoMay2022.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoMay2022.Pages
{
    public class TMPage
    {
        public void CeateTM(IWebDriver driver)
        {
            //click on create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", 2);

            //select Meterial from Typecode drop down button
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]")).Click();

            //identify the Code box and input a code
            driver.FindElement(By.Id("Code")).SendKeys("Material Code1");

            //identify the Description box and input a code
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("First Material Record");

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

        }

       

        public string GetNewCode(IWebDriver driver)
        {
            IWebElement newcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newcode.Text;
        }                                                     
        public string GetNewTypeCode(IWebDriver driver)
        {
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return newTypeCode.Text;
        }
        public string GetNewDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string GetNewPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void EditTM(IWebDriver driver, string description, string code, string price)
        {
            Thread.Sleep(2000);
            //Go to last page where new record created will be
            IWebElement goToLastPageBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn.Click();  
            Thread.Sleep(2000);
            //Select Edit element and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();  
            Console.WriteLine("edit button clicked");
            Thread.Sleep(3500);

            //Select code element and give new input
            //CodeBox.click

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys(code);
            Console.WriteLine("code entered");
            Thread.Sleep(2500);

            //select Description element and new input 

            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys(description);
            Console.WriteLine("new Material description entered");
            Thread.Sleep(2500);

            //identify and clear price per unit and send new input to code

            IWebElement priceInputTags = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTags.Click();
            Thread.Sleep(5000);

            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();
            Thread.Sleep(2000);
            priceInputTags.Click();
            editPrice.SendKeys(price);
            Console.WriteLine("new Material price entered");

            Thread.Sleep(2500);

            //click save element
            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();
            Console.WriteLine("record edit saved");

            Thread.Sleep(2000);
            //Click go to lastPageButton 
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);

            //check the time record is edited
            //IWebElement newEditCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //if (newEditCode.Text == "Code666")
            //{
            //    Console.WriteLine("new time record edited.Test passed");
            //}

            //else
            //{
            //    Console.WriteLine("Time record has not been edited. Test failed");
            //}

            //Assert.That(newEditCode.Text == "Material Code666", "Actual code and expected code do not match");

        }
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }
        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement editprice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editprice.Text;
        }


        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            //delete function
            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Delete Button Clicked");
            Thread.Sleep(2000);

            //Click ok button
            IAlert okButton = driver.SwitchTo().Alert();
            okButton.Accept();
            Console.WriteLine("ok button clicked");
            Thread.Sleep(2000);


            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(3000);

            //check the item is deleted
            IWebElement editedElement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editedElement.Text != "Material Code666")
            {
                Console.WriteLine("row deleted");
            }
            else
            {
                Console.WriteLine("row not deleted");
            }

            //Assertion
            //Assert.That(editedElement.Text == "Material Code666", "Actual code and expected code do not match");

        }



        public void CreateTimeRecord(IWebDriver driver)
        { 
            //click on Administration button
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
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));

            //identify the Code box and input a code
            IWebElement CodeBox = driver.FindElement(By.Id("Code"));
            CodeBox.SendKeys("TimeCode1");

            //identify the Description box and input a code
            IWebElement descriptionBox = driver.FindElement(By.Id("Description"));
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
            Assert.That(newTimeCode.Text == "TimeCode1", "Actual code and expected code do not match");
            //if (newTimeCode.Text == "TimeCode1")
            //{
            //    Console.WriteLine("New time record created successfull,Test Passed");
            //}
            //else
            //{
            //    Console.WriteLine("New time record has not been Created, Test Failed");
            //}
        }    



        public void EditTimeRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Go to last page where new record created will be
            IWebElement goToLastPageBtn= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn.Click();
            Thread.Sleep(2000);
            //Select Edit element and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Console.WriteLine("edit button clicked");
            Thread.Sleep(4500);

            

            //Select code element and give new input
            //CodeBox.click

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("Code666");
            Console.WriteLine("code entered");
            Thread.Sleep(2500);

            //select Description element and new input 

            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("Modified first time record");
            Console.WriteLine("new description entered");
            Thread.Sleep(2500);

            //identify and clear price per unit and send new input to code

            IWebElement priceInputTags = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTags.Click();
            Thread.Sleep(5000);

            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();
            Thread.Sleep(2000);
            priceInputTags.Click();
            editPrice.SendKeys("24");
            Console.WriteLine("new price entered");

            Thread.Sleep(2500);

            //click save element
            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();
            Console.WriteLine("record edit saved");

            Thread.Sleep(2000);
            //Click go to lastPageButton 
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);

            //check the time record is edited
            IWebElement newEditCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //if (newEditCode.Text == "Code666")
            //{
            //    Console.WriteLine("new time record edited.Test passed");
            //}

            //else
            //{
            //    Console.WriteLine("Time record has not been edited. Test failed");
            //}

            Assert.That(newEditCode.Text == "Code666", "Actual code and expected code do not match");

        }


        public void DeleteTimeRecord(IWebDriver driver)
         {
            Thread.Sleep(2000);

            IWebElement goToLastPageButton= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            //delete function
            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Delete Button Clicked");
            Thread.Sleep(2000);

            //Click ok button
            IAlert okButton = driver.SwitchTo().Alert();
            okButton.Accept();
            Console.WriteLine("ok button clicked");
            Thread.Sleep(2000);
            

            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(3000);

            //check the item is deleted
            IWebElement editedElement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editedElement.Text != "Code666")
            {
                Console.WriteLine("row deleted");
            }
            else
            {
                Console.WriteLine("row not deleted");
            }

            //Assertion
            //Assert.That(editedElement.Text == "Code666", "Actual code and expected code do not match");


        }

    }
}
