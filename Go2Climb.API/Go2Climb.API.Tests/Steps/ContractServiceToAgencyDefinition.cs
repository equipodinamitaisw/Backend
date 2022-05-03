using System;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Go2Climb.API.Tests.Steps
{
    [Binding]
    public class ContractServiceToAgencyDefinition
    {
        public static WebDriver webDriver;

        public ContractServiceToAgencyDefinition()
        {
            webDriver = MyWebDriver.getWebdriver();
        }

        [Given(@"the tourist is on the home page")]
        public void GivenTheTouristIsOnTheHomePage()
        {
            
            webDriver.Navigate().GoToUrl("https://go2climb-6758a.web.app/");
            Thread.Sleep(25000);

            
            // webDriver.FindElement(By.XPath("//*[@id='app']/div[1]/header/div/div/div[2]/div/button[2]")).Click();
            //
            // //*[@id="list-item-98"]
            // webDriver.FindElement(By.Id("list-item-48")).Click();
            //
            // webDriver.FindElement(By.XPath("//*[@id='input-59']")).Click();
            // var emailInput = webDriver.FindElement(By.XPath("//*[@id='input-59']"));
            // emailInput.SendKeys("cliente@gmail.com");
            //
            // webDriver.FindElement(By.XPath("//*[@id='input-62']")).Click();
            // var passwordInput = webDriver.FindElement(By.XPath("//*[@id='input-62']"));
            // passwordInput.SendKeys("Cliente1!");
            //
            // webDriver.FindElement(By.XPath("//*[@id='app']/div[4]/div/div/div[1]/form/button/span")).Click();
        }
        
        
        [Given(@"and select the service you wish to contract")]
        public void GivenAndSelectTheServiceYouWishToContract()
        {
            webDriver.FindElement(By.XPath("//*[@id='forYou']/div/div[2]/div/div[1]/div/a/div/div[3]")).Click();
        }
        
        [When(@"fills in the requested information to request the service")]
        public void WhenFillsInTheRequestedInformationToRequestTheService(Table table)
        {
            webDriver.FindElement(By.Id("input-35")).Click();
            var dateInput = webDriver.FindElement(By.Id("input-35"));
            dateInput.SendKeys("05052022");
            
            webDriver.FindElement(By.Id("input-37")).Click();
            var persons = webDriver.FindElement(By.Id("input-37"));
            persons.SendKeys("5");
        }

        [Then(@"click on contract")]
        public void ThenClickOnContract()
        {
            // Click en botón Solicit
            webDriver.FindElement(By.XPath("//*[@id='8']/div/div/div/div[1]/div/div/div[2]/div[1]/div/button/span")).Click();

            // Pasos para cerrar sesión
            // Click en menu hamburguesa
            webDriver.FindElement(By.XPath("//*[@id='app']/div[1]/header/div/div/div[2]/div/button[2]/span/i")).Click();
            //Click en Log Out
            webDriver.FindElement(By.XPath("//*[@id='list-item-71']")).Click();
            webDriver.Close();
        }


        
    }
}