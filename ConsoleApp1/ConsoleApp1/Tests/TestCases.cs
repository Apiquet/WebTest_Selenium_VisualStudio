using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebTests
{
    public class TestCases
    {
        //Choose the browser
        IWebDriver firefoxdriver = new FirefoxDriver();
        public IWebDriver Driver { get => firefoxdriver; set => firefoxdriver = value; }

        //Use LogInPage class
        LogInPage LogIn = new LogInPage();
        //Use HomePage class
        HomePage Home = new HomePage();

        public void Test1()
        {
            //Navigate to``
            Driver.Url = "https://alternativeto.net/?currentLoginView=1&redirectUrl=/";
            //Log In User 1
            LogIn.LogInUser1(Driver);
            //Send a research
            Home.SearchText(Driver, "Test Research");
        }
        
        static void Main(string[] args)
        {
            TestCases TestCase = new TestCases();
            TestCase.Test1();
        }
    }
}
