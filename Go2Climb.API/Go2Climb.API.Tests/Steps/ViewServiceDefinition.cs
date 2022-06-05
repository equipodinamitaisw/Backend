using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class ViewServiceDefinition
    {
        public static WebDriver webdriver;

        ViewServiceDefinition()
        {
            webdriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"is on the advertisement of a service")]
        public void GivenIsOnTheAdvertisementOfAService()
        {
            webdriver.Navigate().GoToUrl("https://go2climb-6758a.web.app");
            Thread.Sleep(6000);
            
        }

        [When(@"press on it")]
        public void WhenPressOnIt()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div[1]/div/div[2]/div/div[1]/div/a/div")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"the system will show you the details of the service")]
        public void ThenTheSystemWillShowYouTheDetailsOfTheService()
        {
            string exp = "Huascaran";
            var res = webdriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div[1]/div/div[1]"))
                .Text;
            Assert.AreEqual(exp,res);
        }
    }
}