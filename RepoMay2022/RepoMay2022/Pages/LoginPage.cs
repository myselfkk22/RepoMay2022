using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoMay2022.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //Maximise window
            driver.Manage().Window.Maximize();

            //launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                //identify username textbox, enter valid username
                driver.FindElement(By.Id("UserName")).SendKeys("hari");

                //identify password textbox, enter valid password
                driver.FindElement(By.Id("Password")).SendKeys("123123");


                //identify login button and click

                driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("TurnUp portal page did not launch.", ex.Message);
            }
            
        }
    }
}
