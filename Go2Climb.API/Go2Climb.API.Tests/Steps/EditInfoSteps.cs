using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class EditInfoSteps
    {
        public static WebDriver webdriver;
        public string user = "update@agencia.com";
        public string pwd = "Update1!";
        public string nuser = "update1@agencia.com";
        public string desc = "prueba 1";

        public EditInfoSteps()
        {
            webdriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"the user is logged")]
        public void GivenTheUserIsLogged()
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

        [When(@"Enters to profile")]
        public void WhenEntersToProfile()
        {
            webdriver.Navigate().GoToUrl("https://go2climb-6758a.web.app/agency/profile");
            Thread.Sleep(2000);
                
            
            
        }

        [When(@"clicks on edit info")]
        public void WhenClicksOnEditInfo()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[1]/div/div/div[2]/div[2]/button/span")).Click();
            webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[1]/div/div/form/div[1]/div/div[1]/div/div[1]/div/input")).SendKeys(desc);
            webdriver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div[1]/div/div/form/div[1]/div/div[2]/div/div[1]/div/input")).SendKeys(nuser);
            webdriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[2]/button[2]")).Click();
        }

        [Then(@"The info will be updated")]
        public void ThenTheInfoWillBeUpdated()
        {
            Thread.Sleep(6000);
            string expect = "prueba 1";
            var element = webdriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]")).Text;
            Assert.AreEqual(expect,element);
            Thread.Sleep(1000);

        }
    }
}