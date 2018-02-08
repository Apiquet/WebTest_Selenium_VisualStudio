using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace WebTests
{
    public class TestCases
    {
        //Choose the browser
        RemoteWebDriver firefoxdriver = new FirefoxDriver();
        public RemoteWebDriver Driver { get => firefoxdriver; set => firefoxdriver = value; }
        string Screenshotpath = "C:/";
        //Use LogInPage class
        LogInPage LogIn = new LogInPage();
        //Use HomePage class
        HomePage Home = new HomePage();
        //Use SearchResultPage class
        SearchResultPage SearchResult = new SearchResultPage();
        //Use EmailManager class
        EmailManager EmailManager = new EmailManager();
        //Use TaskScheduler class
        TaskScheduler TaskScheduler = new TaskScheduler();

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

            //Send Email with a screen shot of the final result
            firefoxdriver.GetScreenshot().SaveAsFile(Screenshotpath, ScreenshotImageFormat.Png);
            EmailManager.SendEmail("Test Research: GoToSecondSearchResult", "", Screenshotpath);

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
            //Verify we are on windows platform
            Assert.IsTrue(Home.IsWindowsPlatformPage(Driver));

            Home.ClickLinuxLink(Driver);
            //Verify we are on Linux platform
            Assert.IsTrue(Home.IsLinuxPlatformPage(Driver));

            Home.ClickMacLink(Driver);
            //Verify we are on Mac platform
            Assert.IsTrue(Home.IsMacPlatformPage(Driver));

            //Log out user
            Home.LogOutUser(Driver);
        }
        public void CreateNewTaskOnTaskScheduler(string hour, string minute)
        {
            //Create the new task
            TaskScheduler.ScheduleTask(hour, minute);
        }

        static void Main(string[] args)
        {
            TestCases TestCase = new TestCases();
            //Navigate to a website, log in user, tape a research and go to the second result
            //Send a mail with a screenshot of the final web page
            TestCase.GoToSecondSearchResult();
            //Navigate between windows / linux / mac platforms
            TestCase.NavigateBetweenPlatforms();
            //schedule a task on Windows TaskScheduler, first argument is hours, second minutes
            if (args.Length == 2) TestCase.CreateNewTaskOnTaskScheduler(args[0], args[1]);
        }
    }
}
