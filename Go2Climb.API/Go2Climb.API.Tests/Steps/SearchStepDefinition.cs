using System.Threading;
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
            webdriver.FindElement(By.Id("input-13")).SendKeys("Huascaran" + Keys.Enter);
            
        }

        [Then(@"the app will display the results")]
        public void ThenTheAppWillDisplayTheResults()
        {
            Thread.Sleep(3000);
            
        }

        [When(@"types the target price")]
        public void WhenTypesTheTargetPrice()
        {
            webdriver.FindElement(By.Id("input-111")).SendKeys("1500");
            Thread.Sleep(1000);
            webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[1]/div/div[2]/main/div/button")).Click();
            /////*[@id="app"]/div/main/div/div/div/div[1]/div/div[2]/main/div/button
            Thread.Sleep(3000);
        }
    }
}