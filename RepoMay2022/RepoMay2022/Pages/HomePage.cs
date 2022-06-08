using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoMay2022.Pages
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            ////click on Administration button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //select Time and Meterial from drop down list
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a")).Click();
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            // navigate to employee page
            ////click on Administration button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //select Employees from drop down button
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")).Click();
        }
    }
}
