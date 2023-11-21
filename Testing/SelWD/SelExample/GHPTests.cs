using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace SelExample
{
    internal class GHPTests
    {
        IWebDriver? driver;
        public void InitializeChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.Manage().Window.Maximize();

        }
        public void InitializeEdgeDriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.google.com";
            driver.Manage().Window.Maximize();
        }

        public void TitleTest()
        {
            Thread.Sleep(10000);
            string title = driver.Title;
            Assert.AreEqual("Google", driver.Title); 
            Console.WriteLine("title Length {0}",title.Length);
            Console.WriteLine("Test Pass");

        }
        public void PageSourceTest()
        {
            /*Console.WriteLine("Page source"+ driver?.PageSource);
            Console.WriteLine("Page Source Length" + driver?.PageSource.Length);
            Assert.AreEqual("https://www.google.com", driver.Url);*/
            Console.WriteLine("Title test pass");
        }
        public void PageURLTest()
        {
            Assert.AreEqual(driver.Url, "http://www.google.com/");
            Console.WriteLine("URL - Test Pass");
        }
        public void GoogleSearchTest()
        {
            IWebElement SearchInputBox = driver.FindElement(By.Id("APjFqb"));
            SearchInputBox.SendKeys("hp laptop");
            Thread.Sleep(5000);
            IWebElement SubmitButton = driver.FindElement(By.ClassName("gNO89b"));                  //Name("btnK"));
            SubmitButton.Click();
            Assert.AreEqual("hp laptop - Google Search",driver.Title);
            Console.WriteLine("Google Search - pass");
            Thread.Sleep(3000);
        }

        public void GmailLinkTest()
        { Thread.Sleep(3000);

            driver.FindElement(By.LinkText("Gmail")).Click();
            
            Assert.That(driver.Title.Contains("Gmail"));
            Console.WriteLine("Gmail test passed");
        }
        public void ImageLinkTest()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.PartialLinkText("Gm")).Click();
            Assert.That(driver.Title.Contains("Gmail"));
            Console.WriteLine("Gmail test passed");
        }
        public void LocalizationTest()
        {
            string loc = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div[1]")).Text;
            Assert.That(loc.Equals("India"));
            Console.WriteLine("xpath test passed");
        }
        public void GAppYouTubeheckTest()
        {
            driver.FindElement(By.ClassName("gb_d")).Click();
      
        }
        public void Destruct()
        {
            driver.Close();
        }
        
    }
}
