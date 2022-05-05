using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class ViewServiceDefinition
    {
        [Given(@"is on the advertisement of a service")]
        public void GivenIsOnTheAdvertisementOfAService()
        {
            ScenarioContext.StepIsPending();
        }
    }
}