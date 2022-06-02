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
        }
    }
}
