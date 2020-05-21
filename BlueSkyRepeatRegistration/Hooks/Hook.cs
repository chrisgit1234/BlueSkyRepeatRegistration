using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DataLabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueSkyRepeatRegistration.Hooks
{
    [Binding]
    public sealed class Hook
    {
        public static IWebDriver driver;


        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //genData=new GenerateData();
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
           
        }
    }
}
