using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebTests
{
    public class SearchResultPage
    {
        public void ClickFirstResult(IWebDriver driver) => FindResult(driver, 1);
        public void ClickSecondResult(IWebDriver driver) => FindResult(driver, 2);
        public void ClickThirdResult(IWebDriver driver) => FindResult(driver, 3);
        internal void FindResult(IWebDriver driver, int number)
        {
            //Link to the specified result
            IWebElement result = driver.FindElement(By.XPath("/html/body/main/div/div/div/ul/li["+number+"]/article/div[2]/h3/a"));
            //Go to specified result
            result.Click();
        }
    }
}
