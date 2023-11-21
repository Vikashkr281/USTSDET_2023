using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelNunitExamples
{
    [TestFixture]
    internal class GHPTests :CoreCodes
    {
        [Ignore("other test have to check")]
        [Test]
        [Order(1)]
        public void CheckForTitle()
        {
            Thread.Sleep(10000);
            string title = driver.Title;
            Assert.AreEqual("Google", title);
            Console.WriteLine("Title test -pass");

        }
        [Ignore("other test have to check")]
        [Test]
        [Order(2)]
        public void GoogleSearchTest()
        {
            IWebElement SearchInputBox = driver.FindElement(By.Id("APjFqb"));
            SearchInputBox.SendKeys("hp laptop");
            Thread.Sleep(5000);
            IWebElement SubmitButton = driver.FindElement(By.ClassName("gNO89b"));                  //Name("btnK"));
            SubmitButton.Click();
            Assert.AreEqual("hp laptop - Google Search", driver.Title);
            Console.WriteLine("Google Search - pass");
           
        }
        [Ignore("other test have to check")]
        [Test]
        public void AllLinksStatusTest()
        {
            List<IWebElement> allLinks=driver.FindElements(By.TagName("a")).ToList();
            foreach(var link in allLinks)
            {
                string url = link.GetAttribute("href");
                if(url == null)
                {
                    Console.WriteLine("URL is null");
                    continue;
                }
                else
                {
                    bool isworking = CheckLinkStatus(url);
                    if(isworking)
                    {
                        Console.WriteLine(url + "is working");
                    }
                    else
                    { Console.WriteLine(url + "is not working"); }
                }
            }
        }

        public bool CheckLinkStatus(string url)
        {
            try
            {
                var request = (System.Net.HttpWebRequest)
                    System.Net.WebRequest.Create(url);

                request.Method = "HEAD";
                using (var response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
