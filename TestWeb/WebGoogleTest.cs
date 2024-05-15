using Allure.NUnit;
using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeb
{




    [TestFixture]
    [AllureNUnit]
    public class WebGoogleTest
    {
        IWebDriver? driver;
        string baseURL = "https://www.google.com/";
        int _IMPLICIT_WAIT = 15;

        [OneTimeSetUp]
    
        public void InitOneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();

            driver = new ChromeDriver(options);
            driver.Url = baseURL;
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(_IMPLICIT_WAIT);
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
        public void TestGoogle1()
        {
            IWebElement _searchBOX = driver.FindElement(By.Name("q"));
            _searchBOX.Click();
            _searchBOX.SendKeys("Selenium\n");
        }


        [Test]
        [AllureStep("Analysis of search result")]
        public void TestResult2()
        {
            IWebElement _toolsBTN = driver.FindElement(By.Id("hdtb-tls"));
            IWebElement _ResultStat = driver.FindElement(By.Id("result-stats"));
            
            _toolsBTN.Click();
            string _ResultText = _ResultStat.Text;
            Console.WriteLine($"Result: {_ResultText}");
        }

        
    
    
    
    
    
    }
}
