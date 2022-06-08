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
    public class EmployeePage

    {
        public void CreateEmplyee(IWebDriver driver)
        {
            
            //Click create button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(2000);
            
            //Send text to name text box
            driver.FindElement(By.Id("Name")).SendKeys("KRISH KANT");
            Thread.Sleep(2000);

            //send text to Username text box
            driver.FindElement(By.Id("Username")).SendKeys("KrishKant");
           
            Thread.Sleep(2000);
            //Identify edit contact button and click
            driver.FindElement(By.Id("EditContactButton")).Click();
            Console.WriteLine("Edit Button clicked");
            Thread.Sleep(2000);

            //Navigate to the popup window
            driver.SwitchTo().Frame(0);
            //Enter the details into contact textboxes
            driver.FindElement(By.Id("FirstName")).SendKeys("Krish");

            driver.FindElement(By.Id("LastName")).SendKeys("Kant");

            driver.FindElement(By.Id("PreferedName")).SendKeys("Krish");

            driver.FindElement(By.Id("Phone")).SendKeys("0444555666"); 

            driver.FindElement(By.Id("Mobile")).SendKeys("0555666777");

            driver.FindElement(By.Id("email")).SendKeys("krishKant123@gmail.com");

            driver.FindElement(By.Id("Fax")).SendKeys("123456");
           
            Thread.Sleep(2000);
            //Address
            driver.FindElement(By.Id("Street")).SendKeys("66 Albert Street");

            driver.FindElement(By.Id("City")).SendKeys("sydney");

            driver.FindElement(By.Id("Postcode")).SendKeys("2765");

            driver.FindElement(By.Id("Country")).SendKeys("Australia");

            Thread.Sleep(2000);
           // Identify save Button and click
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Contact Edit Saved");
            Thread.Sleep(2000);
            //switch back to window
            driver.SwitchTo().DefaultContent();
            
            Thread.Sleep(2000);
            //Send text to password textbox
            driver.FindElement(By.Id("Password")).SendKeys("Krish@K123#");

            Thread.Sleep(2000);
            //Send text to retype password
            driver.FindElement(By.Id("RetypePassword")).SendKeys("Krish@K123#");

            Thread.Sleep(2000);
            //click Isadmin
            driver.FindElement(By.Id("IsAdmin")).Click();

            Thread.Sleep(3000);
            //Select vehicle textbox enter velicle information
            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input")).SendKeys("Brand:Nissan, Colour:Red");
            Thread.Sleep(3000);

            //Select Groups Text drop down and click
            driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]")).Click();
            Thread.Sleep(3000);

            //Select from the Groups options and click
            driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[14]")).Click();
           
            Thread.Sleep(2000);
            //Identify save button and click
            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(2000);
            //identify back to list and click
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();
           
            Thread.Sleep(2000);
            //Identify Gotolastpage and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            // Identify the new employee record created successfuly
            IWebElement newNameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newUsernameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            // Assert 2
            Assert.That(newNameTextBox.Text == "KRISH KANT", "Actual record and expected record do not match.");
            Assert.That(newUsernameTextBox.Text == "KrishKant", "Actual record and expected record do not match.");

        }

        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Identify last page button and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(2000);
            //Identifying created record and click on edit button
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();
            
            Thread.Sleep(2000);
            //Edit text to name text box
            IWebElement editNameBox = driver.FindElement(By.Id("Name"));
            editNameBox.Clear();
            editNameBox.SendKeys("Krish Newedit");
            Thread.Sleep(2000);

            //Edit text to Username text box
            IWebElement editUserNameBox = driver.FindElement(By.Id("Username"));
            editUserNameBox.Clear();    
            editUserNameBox.SendKeys("Krish Newedit");
            Thread.Sleep(2000);


            Thread.Sleep(2000);
            //Identify edit contact button and click
             driver.FindElement(By.Id("EditContactButton")).Click();
            Console.WriteLine("Edit Button clicked");
            Thread.Sleep(2000);

            //Navigate to the popup window
            driver.SwitchTo().Frame(0);
            //Enter the Edit details into contact textboxes
            IWebElement editFirstnameBox = driver.FindElement(By.Id("FirstName"));
            editFirstnameBox.Click();
            editFirstnameBox.SendKeys("Indu");

            IWebElement editLastNameBox = driver.FindElement(By.Id("LastName"));
            editLastNameBox.Clear();
            editLastNameBox.SendKeys("Edited");

            IWebElement editPreferedNameBox = driver.FindElement(By.Id("PreferedName"));
            editPreferedNameBox.Clear();
            editPreferedNameBox.SendKeys("Indu");

            IWebElement editPhoneNumberBox = driver.FindElement(By.Id("Phone"));
            editPhoneNumberBox.Clear();
            editPhoneNumberBox.SendKeys("0444876543");

            IWebElement editMobileBox = driver.FindElement(By.Id("Mobile"));
            editMobileBox.Clear();
            editMobileBox.SendKeys("0555678901");

            IWebElement editEmailBox = driver.FindElement(By.Id("email"));
            editEmailBox.Clear();   
            editEmailBox.SendKeys("InduKant123@gmail.com");

            IWebElement editFaxBox = driver.FindElement(By.Id("Fax"));
            editFaxBox.Clear();
            editFaxBox.SendKeys("6789032");

            Thread.Sleep(2000);
            // Edit Address
            IWebElement editStreetBox = driver.FindElement(By.Id("Street"));
            editStreetBox.Clear();
            editStreetBox.SendKeys("88 Almond Street");

            IWebElement editCityBox = driver.FindElement(By.Id("City"));
            editCityBox.Clear();
            editCityBox.SendKeys("Melbourne");

            IWebElement editPostCodeBox = driver.FindElement(By.Id("Postcode"));
            editPostCodeBox.Clear();
            editPostCodeBox.SendKeys("2823");

            IWebElement EditCountryBox = driver.FindElement(By.Id("Country"));
            EditCountryBox.Clear();
            EditCountryBox.SendKeys("India");
           
            Thread.Sleep(2000);
            // Identify save Button and click
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Contact Edit Saved");
            
            Thread.Sleep(2000);
            //switch back to window
            driver.SwitchTo().DefaultContent();
            
            Thread.Sleep(2000);
            //Edit text to password textbox
            IWebElement editPasswordBox = driver.FindElement(By.Id("Password"));
            editPasswordBox.Clear();
            editPasswordBox.SendKeys("Indu@K123#");

            Thread.Sleep(2000);
            //Edit text to retype password
            IWebElement editRetypePasswordBox = driver.FindElement(By.Id("RetypePassword"));
            editRetypePasswordBox.Clear();
            editRetypePasswordBox.SendKeys("Indu@K123#");

            Thread.Sleep(3000);
            //Select vehicle textbox enter velicle information
            IWebElement editVehicleTextBox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            editVehicleTextBox.Clear();
            editVehicleTextBox.SendKeys("Brand:Honda, Colour:Grey");
           
            Thread.Sleep(3000);
            //Identify save button and click
            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(2000);
            //identify back to list and click
            driver.FindElement(By.XPath("//*[@id='container']/div/a")).Click();
            
            Thread.Sleep(2000);
            //Identify Gotolastpage and click
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();

            //Identify edited employee record creared successfully
            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            // Assert 2
            Assert.That(editedName.Text == "Krish Newedit", "Actual record and expected record do not match.");
            Assert.That(editedUserName.Text == "Krish Newedit", "Actual record and expected record do not match.");


        }

        public void DeleteEmployee(IWebDriver driver)
        {
            // Identify last page button and click
            Thread.Sleep(1000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);
            
            // Identify delete button and click
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            lastRecord.Click();
           
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Ok button clicked");
            Thread.Sleep(3000);

            // Identify last page button and click
            IWebElement lastPageButton1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton1.Click();
            Thread.Sleep(3000);
            //Check the edited record is deleted
            IWebElement theLastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            // Assertion
            Assert.That(theLastRecord.Text != "Krish Newedit", "Employee record has not been deleted successfully.");

        }
    }
}
