using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class AddServiceDefinition
    {
        [Given(@"the agency wants to add new service")]
        public void GivenTheAgencyWantsToAddNewService()
        {
            ScenarioContext.StepIsPending();
        }
    }
}