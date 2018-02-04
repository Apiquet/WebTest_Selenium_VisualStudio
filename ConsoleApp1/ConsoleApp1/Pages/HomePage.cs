using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebTests
{
    public class HomePage
    {
        public void Search(IWebDriver driver, string text) => SearchText(driver, text);
        internal void SearchText(IWebDriver driver, string text)
        {
            //find textbox 
            IWebElement textBox = driver.FindElement(By.Id("algolia-template"));
            //button to search
            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/header/div/div/div/div[2]/form/div/div[2]/div/button"));

            //Send text and click the search button         
            textBox.SendKeys(text);
            searchButton.Click();
        }
    }
}
