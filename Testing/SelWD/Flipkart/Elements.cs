using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart
{
    internal class Elements : Corecode
    {
        [Test]
        public void SearchProduct()
        {
            DefaultWait<IWebDriver> FluentWait = new DefaultWait<IWebDriver>(driver);
            FluentWait.Timeout = TimeSpan.FromSeconds(5);
            FluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            FluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            FluentWait.Message = "Element Not Found";

            IWebElement prod = FluentWait.Until(d=>d.FindElement(By.ClassName("Pke_EE")));
            prod.SendKeys("laptop");
            prod.SendKeys(Keys.Enter);
            IWebElement lap = FluentWait.Until(d => d.FindElement(
           lap.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
        }

    }
}
