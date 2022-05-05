using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class RateServicedefinition
    {
        public static WebDriver webdriver;

        public RateServicedefinition()
        {
            webdriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"The client is logged")]
        public void GivenTheClientIsLogged()
        {   
            ScenarioContext.StepIsPending();
        }

        [Given(@"enters to his profile")]
        public void GivenEntersToHisProfile()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"the client clicks on rate service")]
        public void WhenTheClientClicksOnRateService()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"he will be able to rate the service")]
        public void ThenHeWillBeAbleToRateTheService()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"the client clicks on rate service (.*)")]
        public void WhenTheClientClicksOnRateService(int p0)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"he will not be able to rate the service")]
        public void ThenHeWillNotBeAbleToRateTheService()
        {
            ScenarioContext.StepIsPending();
        }
    }
}