using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebTests
{
    public class LogInPage
    {
        //public functions to log in User 1 and 2
        public void LogInUser1(IWebDriver driver) => LogInUser(driver, "fakemail@gmail.com", "fakemail123");
        public void LogInUser2(IWebDriver driver) => LogInUser(driver, "UserName2", "PassWord");
        //generic log in function
        private void LogInUser(IWebDriver driver, string username, string password)
        {
            //Declaration of IWebElements to log in  
            IWebElement usernameInput = driver.FindElement(By.Id("EmailTextbox"));
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            IWebElement signIn = driver.FindElement(By.Id("RegisterButton"));

            //Send keys and click on log in button            
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            signIn.Click();
        }        
    }
}
