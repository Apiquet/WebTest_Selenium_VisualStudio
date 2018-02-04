using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp1
{
    public class FirstTestCase
    {

        //Choose the browser
        IWebDriver driver = new FirefoxDriver();
        public IWebDriver Driver { get => driver; set => driver = value; }

        public void Test()
        {
            LogInPage LogIn = new LogInPage();
            //Navigate to
            Driver.Url = "https://www.facebook.com/";
            LogIn.LogInUser1(Driver);
        }

        static void Main(string[] args)
        {
            FirstTestCase MainLoop = new FirstTestCase();
            MainLoop.Test();
        }
    }
}
