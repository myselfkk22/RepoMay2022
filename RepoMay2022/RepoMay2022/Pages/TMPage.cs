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
            WaitHelpers.WaitToBeClickable(driver,"XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", 2);

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

        }

        internal void DeleteTM(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        internal void EditTM(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        public void EditTM(IWebElement driver)
        {

            ////Select Edit element and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Console.WriteLine("edit button clicked");
            Thread.Sleep(4500);

            //Select time option typecode dropdown
            //IWebElement dropDownOption = driver.FindElement(By.XPath("//*[@id=TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            //dropDownOption.Click();

            //IWebElement tmOption = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            //tmOption.Click();
            //Thread.Sleep(3500);

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
            IWebElement goToLastPageButtton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButtton.Click();
            Thread.Sleep(2000);

            //check the time record is edited
            IWebElement editNewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (editNewCode.Text == "Code666")
            {
                Console.WriteLine("new time record edited.Test passed");
            }

            else
            {
                Console.WriteLine("Time record has not been edited. Test failed");
            }
        }
        
        
        public void DeleteTM(IWebElement driver)
         {
            //delete function
            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Delete Button Clicked");
            Thread.Sleep(2000);

            //Click ok button
            IAlert Alert = driver.SwitchTo().Alert();
            Alert.Accept();
            Console.WriteLine("ok button clicked");
            Thread.Sleep(2000);

            //check the item is deleted
            IWebElement delElement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (delElement.Text != "Code666")
            {
                Console.WriteLine("row deleted");
            }
            else
            {
                Console.WriteLine("row not deleted");
            }


        }

    }
}
