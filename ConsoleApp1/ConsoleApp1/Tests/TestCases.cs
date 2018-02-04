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
        //Use SearchResultPage class
        SearchResultPage SearchResult = new SearchResultPage();

        public void GoToSecondSearchResult()
        {
            //Navigate to
            Driver.Url = "https://alternativeto.net/?currentLoginView=1&redirectUrl=/";
            //Log In User 1
            LogIn.LogInUser1(Driver);
            //Send a research
            Home.SearchText(Driver, "Test Research");
            //Go to the second result
            SearchResult.ClickSecondResult(Driver);

            //Log out user
            Home.LogOutUser(Driver);
        }

        public void NavigateBetweenPlatforms()
        {
            //Navigate to
            Driver.Url = "https://alternativeto.net/?currentLoginView=1&redirectUrl=/";

            //Log In User 1
            LogIn.LogInUser1(Driver);

            //Navigate between platforms
            Home.ClickWindowsLink(Driver);
            Home.ClickLinuxLink(Driver);
            Home.ClickMacLink(Driver);

            //Log out user
            Home.LogOutUser(Driver);
        }

        static void Main(string[] args)
        {
            TestCases TestCase = new TestCases();
            TestCase.GoToSecondSearchResult();
            TestCase.NavigateBetweenPlatforms();
        }
    }
}
