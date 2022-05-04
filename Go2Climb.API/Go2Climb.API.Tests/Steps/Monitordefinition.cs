using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class Monitordefinition
    {
        public static WebDriver webdriver;
        public string user = "agencia2@gmail.com";
        public string pwd = "Agencia1!";
        

        public Monitordefinition()
        {
            webdriver = MyWebDriver.getWebdriver();
            
        }
        
        [Given(@"the user is logged in")]
        public void GivenTheUserIsLogeddIn()
        {
            webdriver.Navigate().GoToUrl("https://go2climb-6758a.web.app");
            Thread.Sleep(2000);
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]")).Click();
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/div[1]/div/div[1]/div/input")).SendKeys(user);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/div[2]/div/div[1]/div/input")).SendKeys(pwd);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/button/span")).Click();
            Thread.Sleep(2000);
            
        }

        [Given(@"clicks on the clients tab")]
        public void GivenClicksOnTheClientsTab()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]")).Click();
            Thread.Sleep(2000);
            
            
        }

        [When(@"he changes service the status to active")]
        public void WhenHeChangesServiceTheStatusToActive()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div/div/div/div[2]/div/div[1]/table/tbody/tr[5]/td[8]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div[1]/div[2]/div/div[1]/div[1]/div[1]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[5]/div/div[2]")).Click();
            Thread.Sleep(100);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div[2]/button[2]")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"the status will be updated")]
        public void ThenTheStatusWillBeUpdated()
        {
            string expc = "active";
            var res = webdriver
                .FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/div/div/div/div[2]/div/div[1]/table/tbody/tr[5]/td[8]/div[1]/span/div"))
                .Text;
            Assert.AreEqual(expc,res);
            Thread.Sleep(2000);
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]")).Click();
        }

        [When(@"he changes service the status to finished")]
        public void WhenHeChangesServiceTheStatusToFinished()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div/div/div/div[2]/div/div[1]/table/tbody/tr[5]/td[8]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div[1]/div[2]/div/div[1]/div[1]/div[1]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[5]/div/div[3]")).Click();
            Thread.Sleep(100);
            webdriver.FindElement(By.XPath("/html/body/div/div[4]/div[2]/button[2]")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"the status will be updated to finished")]
        public void ThenTheStatusWillBeUpdatedToFinished()
        {
            string expc = "finished";
            var res = webdriver
                .FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/div/div/div/div[2]/div/div[1]/table/tbody/tr[5]/td[8]/div[1]/span/div"))
                .Text;
            Assert.AreEqual(expc,res);
            Thread.Sleep(2000);
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]")).Click();
            
        }
    }
}