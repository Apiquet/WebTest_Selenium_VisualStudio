using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp1
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            //Choose the browser
            IWebDriver driver = new FirefoxDriver();
            //Navigate to
            driver.Url = "https://www.facebook.com/";
            
        }
    }
}
