using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Input;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelNunitExamples
{
    internal class LinkedinTests:CoreCodes
    {
        [Test]
        [Author("Poornima","vikash@")]
        [Description("Check for valid Login")]
        [Category("Regression Testing")]
        /* public void LoginTest()
         {
             //WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(5));
             // IWebElement login =wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_key")));
             DefaultWait<IWebDriver> FluentWait = new DefaultWait<IWebDriver>(driver);
             FluentWait.Timeout=TimeSpan.FromSeconds(5);
             FluentWait.PollingInterval=TimeSpan.FromMilliseconds(100);
             FluentWait.IgnoreExceptionTypes (typeof(NoSuchElementException));
             FluentWait.Message = "Element Not Found";
             IWebElement login = FluentWait.Until(d => d.FindElement(By.Id("session_key")));
             login.SendKeys("VikashKr281997@gmail.com");

             // IWebElement password = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_password")));
             IWebElement password = FluentWait.Until(d => d.FindElement(By.Id("session_password")));
             password.SendKeys("21345678");

             TakeScreenShot();*/

        public void Login1Test()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(3);
            /*
            IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_key")));
            IWebElement passwordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_password")));
            */
            /*
            IWebElement emailInput = wait.Until(d=>d.FindElement(By.Id("session_key")));
            IWebElement passwordInput = wait.Until(d=>d.FindElement(By.Id("session_password")));
            */

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = wait.Until(d => d.FindElement(By.Id("session_key")));
            IWebElement passwordInput = wait.Until(d => d.FindElement(By.Id("session_password")));
            emailInput.SendKeys("pwd.com");
            passwordInput.SendKeys("pwd");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Thread.Sleep(1000);
        }
        [Test]
        [Author("Shirin", "sheri@qwa.com")]
        [Description("Check for Invalid Login")]
        [Category("Smoke Testing")]
        public void LoginTestWithInvalidCredential()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = wait.Until(d => d.FindElement(By.Id("session_key")));
            IWebElement passwordInput = wait.Until(d => d.FindElement(By.Id("session_password")));
            emailInput.SendKeys("qwerty@wer.com");
            passwordInput.SendKeys("qwer");
            Thread.Sleep(3000);
            ClearForm(emailInput);
            ClearForm(passwordInput);

            emailInput.SendKeys("rose@gn.com");
            passwordInput.SendKeys("blueRose");
            Thread.Sleep(3000);
            ClearForm(emailInput);
            ClearForm(passwordInput);

            emailInput.SendKeys("black@lok.com");
            passwordInput.SendKeys("black");
            Thread.Sleep(3000);
            ClearForm(emailInput);
            ClearForm(passwordInput);
        }

        void ClearForm(IWebElement element)
        {
            element.Clear();
        }

        [Test]
        [Author("Shirin", "sheri@qwa.com")]
        [Description("Check for Invalid Login")]
        [Category("Regression Testing")]
        //[TestCase("qwerty@wer.com", "qwer")]
        //[TestCase("rose@gn.com", "blueRose")]
        //[TestCase("black@lok.com", "black")]
        [TestCaseSource(nameof(InvalidLoginData))]
        public void Login3Test(string email, string pwd)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            IWebElement emailInput = wait.Until(d => d.FindElement(By.Id("session_key")));
            IWebElement passwordInput = wait.Until(d => d.FindElement(By.Id("session_password")));

            emailInput.SendKeys(email);
            passwordInput.SendKeys(pwd);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath("//button[@type='submit']")));
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//button[@type='submit']")));
            Thread.Sleep(3000);
            TakeScreenShot();
            ClearForm(emailInput);
            ClearForm(passwordInput);

            Thread.Sleep(3000);
        }

        static object[] InvalidLoginData()
        {
            return new object[]
            {
                new object[] { "qwerty@wer.com", "qwer" },
                new object[] { "rose@gn.com", "blueRose" },
                new object[] { "black@lok.com", "black" }
            };
           
            //IWebElement show = driver.FindElement(By.XPath("//button[@class='font-sans text-md font-bold text-color-action z-10 ml-[12px] hover:cursor-pointer']"));
            //show.Click();

            

        }

       
       
    }
}
