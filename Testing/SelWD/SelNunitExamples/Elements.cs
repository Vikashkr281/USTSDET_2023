using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SelNunitExamples
{
    internal class Elements :CoreCodes
    {
        /*[Test]
        public void TestCheckBox()
        {
            IWebElement element = driver.FindElement(By.XPath("//h5[text()='Elements']//parents::div"));
            IWebElement cbmenu = driver.FindElement(By.XPath("//span[text()='Check Box']"));
            cbmenu.Click();
            List<IWebElement> expandcollaps = driver.FindElements(By.ClassName("rct-node rct-node-parent rct-node-expanded")).ToList();
            foreach(var item in expandcollaps) 
            {
                item.Click();
            }
            IWebElement commandscheckbox = driver.FindElement(By.XPath("//span[text()='commands']"));   
            commandscheckbox.Click();
            Assert.True(driver.FindElement(By.XPath("//input[@id,'commands']")).Selected);
     
        }*/
        [Test]
        public void TestFormElement()
        {
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Vikash");
            Thread.Sleep(2000);
            IWebElement LastName = driver.FindElement(By.Id("lastName"));
            LastName.SendKeys("Mishra");
            Thread.Sleep(3000);
            IWebElement Email = driver.FindElement(By.Id("userEmail"));
            Email.SendKeys("Vikashkr281997@gmail.com");
            Thread.Sleep(3000);
            // IWebElement gender = driver.FindElement(By.XPath("//input[@id='gender-radio-1']//following::label"));
            //gender.Click();
            IWebElement gender = driver.FindElement(By.XPath("//label[text()='Male']"));
            gender.Click();
            Thread.Sleep(3000);
            IWebElement Mobile = driver.FindElement(By.Id("userNumber"));
            Mobile.SendKeys("7903324843");
            Thread.Sleep(3000);
            IWebElement Birthday = driver.FindElement(By.Id("dateOfBirthInput"));
            Birthday.Click();
            Thread.Sleep(3000);
            IWebElement DobMonth = driver.FindElement(By.ClassName("react-datepicker__month-select"));
            SelectElement select = new SelectElement(DobMonth);
            select.SelectByIndex(5);
            Thread.Sleep(3000);
            IWebElement Year = driver.FindElement(By.ClassName("react-datepicker__year-select"));
            SelectElement select1 = new SelectElement(Year);
            select1.SelectByText("1998");
            Thread.Sleep(3000);
            IWebElement date = driver.FindElement(By.XPath("//div[text()='10']"));
            date.Click();
            /*SelectElement dateSelect = new SelectElement(date);
            dateSelect.SelectByIndex(5);*/
            Thread.Sleep(3000);
            // IWebElement Month=driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select'"))
            IWebElement Subject = driver.FindElement(By.Id("subjectsInput"));
            Subject.SendKeys("math");
            Subject.SendKeys(Keys.Enter);
            Subject.SendKeys(Keys.Space);
            Subject.SendKeys("English");
            Subject.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement hobbie = driver.FindElement(By.XPath("//label[text()='Sports']"));
            hobbie.Click();
           
           
            Thread.Sleep(3000);
            IWebElement hobbie1 = driver.FindElement(By.Id("hobbies-checkbox-2"));
            Thread.Sleep(3000);
            IWebElement Picture = driver.FindElement(By.Id("uploadPicture"));
            Thread.Sleep(3000);
            Picture.SendKeys("C:\\Users\\Administrator\\Downloads");
            IWebElement Address = driver.FindElement(By.Id("currentAddress"));
            Address.SendKeys("bihar");
            Thread.Sleep(3000);
            

            
        }
      
    }
}
