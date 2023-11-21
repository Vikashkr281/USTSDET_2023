using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelNunitExamples 
{
    [TestFixture]
    internal class ActionsEvents :CoreCodes
    {
        [Test]
        public void HomeLinkTest()
        {
            IWebElement homelink=driver.FindElement(By.LinkText("Home"));
            IWebElement tdhomelink = driver.FindElement(By.XPath("//tr[@class='mouseOut'][1]"));
            Actions actions = new Actions(driver);
            Action mouseOverAction = () => actions.MoveToElement(homelink).Build().Perform();
            Console.WriteLine("Before :" + tdhomelink.GetCssValue("background-color"));
            mouseOverAction.Invoke();
            Console.WriteLine("After :" + tdhomelink.GetCssValue("background-color"));
            Thread.Sleep(3000);
        }
    }
}
