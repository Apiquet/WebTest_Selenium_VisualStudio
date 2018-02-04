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
        
        public void SearchText(IWebDriver driver, string text)
        {
            //find textbox 
            IWebElement textBox = driver.FindElement(By.Id("algolia-template"));
            //button to search
            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/header/div/div/div/div[2]/form/div/div[2]/div/button"));

            //Send text and click the search button         
            textBox.SendKeys(text);
            searchButton.Click();
        }

        public void ClickWindowsLink(IWebDriver driver) => ClickButton(driver, 2);
        public void ClickMacLink(IWebDriver driver) => ClickButton(driver, 3);
        public void ClickLinuxLink(IWebDriver driver) => ClickButton(driver, 4);
        private void ClickButton(IWebDriver driver, int number)
        {
            //id home page button
            IWebElement linkButton = driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/ul[1]/li["+number+"]/a"));

            //click button
            linkButton.Click();
        }
    }
}
