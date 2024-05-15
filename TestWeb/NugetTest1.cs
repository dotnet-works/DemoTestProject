using Allure.NUnit.Attributes;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.NUnit;
using System.Collections;

namespace TestWeb
{
    

    [AllureNUnit]
    [TestFixture]
    public class NugetTest1
    {
        IWebDriver? driver;
        string baseURL = "https://www.google.com/";
        int _IMPLICIT_WAIT = 15;

        Func<IList<IWebElement> ,IList<string>>? getEleTextList;

        [OneTimeSetUp]

        public void InitOneTimeSetUp()
        {
            
            

            ChromeOptions options = new ChromeOptions();

            driver = new ChromeDriver(options);
            driver.Url = baseURL;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_IMPLICIT_WAIT);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void OneTimeCleanUp()
        {
            driver.Close();
            driver.Dispose();
        }

        [Test]
        [AllureStep("simple google search")]
        public void Test1()
        {
            IWebElement _searchBOX = driver.FindElement(By.Name("q"));
            _searchBOX.Click();
            _searchBOX.SendKeys("Selenium\n");
        }


        [Test]
        [AllureStep("Analysis of search result")]
        public void Test2()
        {
            IWebElement _toolsBTN = driver.FindElement(By.Id("hdtb-tls"));
            IWebElement _ResultStat = driver.FindElement(By.Id("result-stats"));

            _toolsBTN.Click();
            string _ResultText = _ResultStat.Text;
            Console.WriteLine($"Result: {_ResultText}");

           //getEleTextList = GetElementList;
           
           IList<string> eText = GetElementList(driver.FindElements(By.XPath("//h3")));
           


        }


        public static IList<string> GetElementList(IList<IWebElement> eList)
        {
            List<string> allHeadingText = new List<string>();
            foreach (IWebElement e in eList)
            {
                Console.WriteLine($"Text: {e.Text}");
                allHeadingText.Add(e.Text);
            }
            return allHeadingText;
        }

    }
}
    
    
    
