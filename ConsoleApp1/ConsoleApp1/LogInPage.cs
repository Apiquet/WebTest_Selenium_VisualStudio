using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp1
{
    public class LogInPage
    {
        public void LogInUser1(IWebDriver driver) => LogInUser(driver, "UserNameTest", "PassWordTest");
        internal void LogInUser(IWebDriver driver, string username, string password)
        {
            //Declaration of IWebElements to log in  
            IWebElement usernameInput = driver.FindElement(By.Id("email"));
            IWebElement passwordInput = driver.FindElement(By.Id("pass"));
            IWebElement signIn = driver.FindElement(By.XPath("//input[@value='Log In']"));

            //Send keys and click on log in button
            usernameInput.SendKeys("TEST");
            passwordInput.SendKeys("TEST");
            signIn.Click();
        }
        
    }
}
