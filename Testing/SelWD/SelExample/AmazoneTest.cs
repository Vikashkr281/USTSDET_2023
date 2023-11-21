using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelExample
{
    internal class AmazoneTest
    {
        IWebDriver? driver;
        public void InitializeChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.amazon.com";
            driver.Manage().Window.Maximize();

        }
        public void InitializeEdgeDriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.amazon.com";
            driver.Manage().Window.Maximize();
        }

        public void TitleTest()
        {
            Thread.Sleep(10000);
            string title = driver.Title;
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("title Length {0}", title.Length);
            Console.WriteLine("Test Pass");

        }
        public void LogoClickTest()
        {
            driver.FindElement(By.Id("nav-logo-sprites")).Click();
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("Test case pass");
        }

        public void searchMobile()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobile");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            Assert.That(("Amazon.com : mobile".Equals(driver.Title)) && (driver.Url.Contains("mobile")));
            Thread.Sleep(3000);
        }
        public void ReloadPage()
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://Amazon.com");
            Thread.Sleep(3000);
        }
        public void TodayDeals()
        {
          IWebElement todayDeals=  driver.FindElement(By.LinkText("Today's Deals"));
               if(todayDeals == null) { 
                throw new NoSuchElementException("Todays deals not present");

            
            }
               todayDeals.Click();
            Assert.That(driver.FindElement(By.TagName("h1")).Text.Equals("Today's Deals"));
            Console.WriteLine("TodayDeals is passs");
            Thread.Sleep(2000);
        }
        public void SignInAccListTest()
        {
            IWebElement hellosignin = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            if(hellosignin == null) { 
            throw new NoSuchElementException("Hello sign not present ");
            }
            IWebElement accountAndList = driver.FindElement(By.XPath("//*[@id=\"nav-link-accountList\"]/span"));
           if(accountAndList == null) 
            {
                throw new NoSuchElementException("Hello , Account & Lists is not present");
            }

                Assert.That(hellosignin.Text.Equals("Hello, sign in"));
       
            Console.WriteLine("Hello,sign in present - pass");
            Assert.That(accountAndList.Text.Equals("Account & Lists"));
            Console.WriteLine("Account & List is present - pass");

        }
        public void SearchAndfilterByBrandTest()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("MOBILE PHONE");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
           IWebElement motocheck= driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/i"));
            motocheck.Click();
            Thread.Sleep(4000);
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/input")).Selected);
            Console.WriteLine("motorola is selected");
            driver.FindElement(By.ClassName("a-expander-prompt")).Click() ;
            IWebElement AppleCheck = driver.FindElement(By.XPath("//*[@id=\"p_89/Apple\"]/span/a/div/label/i"));
            AppleCheck.Click();
            Thread.Sleep(3000);
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/Apple\"]/span/a/div/label/i")).Selected);
            
            Console.WriteLine("Test passed");

        }
     
        public void Destruct()
        {
            driver.Close();
        }
    }
}
