using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class pruebaselenium
    {
        public static WebDriver webdriver;

        public pruebaselenium()
        {
            webdriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"the first number is")]
        public void GivenTheFirstNumberIs()
        {
            webdriver.Navigate().GoToUrl("https://www.youtube.com");
            
        }


        [Given(@"the second number is")]
        public void GivenTheSecondNumberIs()
        {
            webdriver.Navigate().GoToUrl("https://www.facebook.com");
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            webdriver.Navigate().GoToUrl("https://www.twitter.com");
        }
        [Then(@"the result should be")]
        public void ThenTheResultShouldBe()
        {
            webdriver.Close();
            
        }

        
    }
}