using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class RateServicedefinition
    {
        public static WebDriver webdriver;
        public string user = "cliente@gmail.com";
        public string pwd = "Cliente1!";

        public RateServicedefinition()
        {
            webdriver = MyWebDriver.getWebdriver();
           
        }
        
        [Given(@"The client is logged")]
        public void GivenTheClientIsLogged()
        {   
            webdriver.Navigate().GoToUrl("https://go2climb-6758a.web.app");
            Thread.Sleep(2000);
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(1000);
            webdriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]")).Click();
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/div[1]/div/div[1]/div/input")).SendKeys(user);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/div[2]/div/div[1]/div/input")).SendKeys(pwd);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/button/span")).Click();
            Thread.Sleep(2000);
            
        }

        [Given(@"enters to his profile")]
        public void GivenEntersToHisProfile()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]")).Click();
            Thread.Sleep(1000);
        }

        [When(@"the client clicks on rate service")]
        public void WhenTheClientClicksOnRateService()
        {   
            webdriver.FindElement((By.XPath("/html[1]/body[1]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[5]/button[1]/span[1]"))).Click();
            Thread.Sleep(500);
        }

        [Then(@"he will be able to rate the service")]
        public void ThenHeWillBeAbleToRateTheService()
        {
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[5]/div/div/div[1]/form/div[1]/div/div[1]/div/input"))
                .SendKeys("4");
            webdriver.FindElement(By.XPath(
                "/html/body/div/div[5]/div/div/div[1]/form/div[2]/div/div[1]/div/textarea")).SendKeys("Buen servicio");
            webdriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div[1]/div[2]/button")).Click();
        }
        
        [When(@"the client clicks on rate on a service")]
        public void WhenTheClientClicksOnRateOnAService()
        {
            Thread.Sleep(500);
            
        }
      
        [Then(@"he will not be able to rate the service")]
        public void ThenHeWillNotBeAbleToRateTheService()
        {
            string exp = "RATE SERVICE";
            var res =webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/div/div/div/div/div[3]/table/tbody/tr[1]/td[5]/button"))
                .Text;
            Assert.AreEqual(exp,res);
        }

       
    }
}