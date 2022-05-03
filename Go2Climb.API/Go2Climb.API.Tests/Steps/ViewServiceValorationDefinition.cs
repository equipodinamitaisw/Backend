using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class ViewServiceValorationDefinition
    {
        public static WebDriver webDriver;

        public ViewServiceValorationDefinition()
        {
            webDriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"the tourist would like to see ratings from an agency")]
        public void GivenTheTouristWouldLikeToSeeRatingsFromAnAgency()
        {
            webDriver.Navigate().GoToUrl("https://go2climb-6758a.web.app/");
            
            webDriver.FindElement(By.XPath("//*[@id='app']/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            
            //*[@id="list-item-98"]
            webDriver.FindElement(By.Id("list-item-48")).Click();

            webDriver.FindElement(By.XPath("//*[@id='input-59']")).Click();
            var emailInput = webDriver.FindElement(By.XPath("//*[@id='input-59']"));
            emailInput.SendKeys("cliente@gmail.com");
            
            webDriver.FindElement(By.XPath("//*[@id='input-62']")).Click();
            var passwordInput = webDriver.FindElement(By.XPath("//*[@id='input-62']"));
            passwordInput.SendKeys("Cliente1!");
            
            webDriver.FindElement(By.XPath("//*[@id='app']/div[4]/div/div/div[1]/form/button/span")).Click();
            
            
        }

        [Given(@"click on the agency's website")]
        public void GivenClickOnTheAgencysWebsite()
        {
            webDriver.FindElement(By.XPath("//*[@id='forYou']/div/div[2]/div/div[3]/div/a/div/div[3]")).Click();
        }

        [Then(@"in the reviews section you will be able to visualize the valuation of the agency")]
        public void ThenInTheReviewsSectionYouWillBeAbleToVisualizeTheValuationOfTheAgency()
        {
            webDriver.FindElement(By.XPath("//*[@id='24']/div/div/div/div[2]/div[1]/div/div[2]/div[2]/div"));
            
            // Pasos para cerrar sesión
            // Click en menu hamburguesa
            webDriver.FindElement(By.XPath("//*[@id='app']/div[1]/header/div/div/div[2]/div/button[2]/span/i")).Click();
            //Click en Log Out
            webDriver.FindElement(By.XPath("//*[@id='list-item-71']")).Click();
            webDriver.Close();
        }
    }
}