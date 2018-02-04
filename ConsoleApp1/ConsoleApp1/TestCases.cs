using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp1
{
    public class TestCases
    {
        //Choose the browser
        IWebDriver firefoxdriver = new FirefoxDriver();
        public IWebDriver Driver { get => firefoxdriver; set => firefoxdriver = value; }

        //Use LogInPage class
        LogInPage LogIn = new LogInPage();

        public void Test1()
        {
            //Navigate to
            Driver.Url = "https://www.facebook.com/";
            //Log In User 1
            LogIn.LogInUser1(Driver);
        }
        
        static void Main(string[] args)
        {
            TestCases TestCase = new TestCases();
            TestCase.Test1();
        }
    }
}
