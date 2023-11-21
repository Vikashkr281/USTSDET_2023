using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V117.WebAuthn;

namespace SelExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GHPTests gHPTests = new GHPTests();
            List<string> driver = new List<string>();
            driver.Add("Edge");
            driver.Add("Chrome");
            foreach (string d in driver)
            {
                AmazoneTest ag = new AmazoneTest();
                /*Console.WriteLine("1. Edge  2. Chrome");
                int ch=Convert.ToInt32(Console.ReadLine());*/
                switch (d)
                {
                    case "Edge":
                        ag.InitializeEdgeDriver();
                        break;
                    case "Chrome":
                        ag.InitializeChromeDriver();
                        break;
                }


                try
                {


                  /*  ag.TitleTest();
                    ag.LogoClickTest();
                    ag.searchMobile();
                    ag.ReloadPage();
                    ag.TodayDeals();*/
                  //ag.SignInAccListTest();
                    ag.SearchAndfilterByBrandTest();
                    

                }
                catch (AssertionException)
                {
                    Console.WriteLine("fail");

                }
                catch(NoSuchElementException nse)
                {
                    Console.WriteLine(nse.Message);
                }

                // driver.Close();
                ag.Destruct();

            }

           
        }
    }
}