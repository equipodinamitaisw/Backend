using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class AddServiceDefinition
    {
        public static WebDriver webdriver;
        public string user = "agencia2@gmail.com";
        public string pwd = "Agencia1!";

        public AddServiceDefinition()
        {
            webdriver = MyWebDriver.getWebdriver();
        }
        
        [Given(@"the agency wants to add new service")]
        public void GivenTheAgencyWantsToAddNewService()
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
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            Thread.Sleep(500);
            webdriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]")).Click();
            Thread.Sleep(3000);
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div[1]/div[2]/button[2]/span")).Click();
            Thread.Sleep(500);
            
        }

        [When(@"owner add a service")]
        public void WhenOwnerAddAService()
        {
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[1]/div[2]/div[1]/div/div/div/input"))
                .SendKeys("Servicio nuevo");
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[1]/div[2]/div[2]/div/div/div/textarea"))
                .SendKeys("prueba");
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[1]/div[2]/div[3]/div/div/div/input"))
                .SendKeys("Lima");
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[1]/div[2]/div[4]/div/div/div/input"))
                .SendKeys("https://freewalkingtoursperu.com/wp-content/uploads/2020/05/things-to-do-lima-what-todo-lima-peru.jpg");
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[2]/div[2]/div/div/div[1]/div/input"))
                .SendKeys("500");
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[2]/div[3]/div[1]/div/div/div[1]/div/input"))
                .SendKeys("22022022");
            webdriver.FindElement(By.XPath(
                    "/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/form[1]/div[2]/div[3]/div[2]/div/div/div[1]/div/input"))
                .SendKeys("22062022");
            
            
        }

        [Then(@"the service will be added")]
        public void ThenTheServiceWillBeAdded()
        {
            webdriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/main/div/div/div/div/div[3]/button[2]/span")).Click();
        }
    }
}