using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Naaptol
{
    internal class Elements :CoreCodes
    {
        DefaultWait<IWebDriver> FluentWait;
        public void waits()
        {
            FluentWait = new DefaultWait<IWebDriver>(driver);
            FluentWait.Timeout = TimeSpan.FromSeconds(5);
            FluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            FluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            FluentWait.Message = "Element Not Found";
        }
        [Test]
        [Order(0)]
        public void SearchElements()
        {
            waits();
            IWebElement search = FluentWait.Until(d => d.FindElement(By.Id("header_search_text")));
            search.SendKeys("Eyewear");

            search.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement select = FluentWait.Until(d => d.FindElement(By.Id("productItem5")));
            select.Click();
            List<string> list=driver.WindowHandles.ToList();
            driver.SwitchTo().Window(list[1]);
        }
        [Test]
        [Order(1)]
           public void AddToCart()
            {
            waits();
            IWebElement select1=FluentWait.Until(d => d.FindElement(By.LinkText("Black-2.50")));
            select1.Click();
            IWebElement add = FluentWait.Until(d => d.FindElement(By.XPath("//span[text()='Click here to Buy']")));
            add.Click();
            Thread.Sleep(3000);
            IWebElement gift = FluentWait.Until(d => d.FindElement(By.Id("cvName")));
            gift.SendKeys("12345");
            Thread.Sleep(3000);
            IWebElement apply = FluentWait.Until(d => d.FindElement(By.Id("cvApplybtn")));
            apply.Click();
            Thread.Sleep(3000);
           

        }
        [Test]
        [Order(2)]
        public void  viewCart()
        {
            waits();

            IWebElement selectedElement = FluentWait.Until(d => d.FindElement(By.LinkText("Foldable Reading Glasses (FRG2)")));
            Assert.AreEqual(selectedElement.Text, "Foldable Reading Glasses (FRG2)");
            Console.WriteLine("The product you selected and in the cart is same. Buy Now");
         
        }
    }
}
