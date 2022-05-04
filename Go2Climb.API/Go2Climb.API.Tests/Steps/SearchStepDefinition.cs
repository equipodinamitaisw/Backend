using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class SearchStepDefinition
    {
        public static WebDriver webdriver;

        public SearchStepDefinition()
        {
            webdriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"the tourist wants to travel")]
        public void GivenTheTouristWantsToTravel()
        {
            webdriver.Navigate().GoToUrl("https://go2climb-6758a.web.app");
            Thread.Sleep(2000);
        }

        [When(@"the tourist types the name of the service")]
        public void WhenTheTouristTypesTheNameOfTheService()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div/header/div/div/div[3]/div/div/div/div/div[2]/input")).SendKeys("Huascaran" + Keys.Enter);
            
        }

        [Then(@"the app will display the results")]
        public void ThenTheAppWillDisplayTheResults()
        {
            Thread.Sleep(2000);
            
        }

        [When(@"types the target price")]
        public void WhenTypesTheTargetPrice()
        {
            var expect = "Found 1 matches for Huascaran";
            webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[1]/div/div[2]/main/div/div[1]/div/div[1]/div/input")).SendKeys("1500");
            Thread.Sleep(1000);
            webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[1]/div/div[2]/main/div/button/span")).Click();
            
            Thread.Sleep(3000);
            var element = webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[2]/div/div[1]/div")).Text;
            
            
            Assert.AreEqual(expect,element);
            Thread.Sleep(1000);
        }

        [Then(@"The test ends")]
        public void ThenTheTestEnds()
        {
            webdriver.Quit();
            
        }
    }
}