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
            // Abre el front
            webDriver.Navigate().GoToUrl("https://go2climb-6758a.web.app/");
            Thread.Sleep(5000);

            // Busca y da click el menu tipo hamburguesa
            webDriver.FindElement(By.XPath("/html/body/div[1]/div/header/div/div/div[2]/div/button[2]")).Click();
            
            // Busca y da click al elemento de la lista "Sign In"
            webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]")).Click();

            // Busca el input de Email 
            var emailInput = webDriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/div[1]/div/div[1]/div/input"));
            // Le da click al input de email
            emailInput.Click();
            // Escribe en el input el email
            emailInput.SendKeys("cliente@gmail.com");
            
            // Busca el input de Password
            var passwordInput = webDriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/div[2]/div/div[1]/div/input"));
            // Le da click
            passwordInput.Click();
            // Ingresa la contraseña el input
            passwordInput.SendKeys("Cliente1!");
            
            // Busca y da click en el boton Sign In
            webDriver.FindElement(By.XPath("/html/body/div/div[4]/div/div/div[1]/form/button/span")).Click();
            Thread.Sleep(5000);
        }
        
        
        [Given(@"and select the service you wish to contract")]
        public void GivenAndSelectTheServiceYouWishToContract()
        {
            // Busca y da click en un servicio que se encuentre disponible
            webDriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div[1]/div/div[2]/div/div/div")).Click();
        }
        
        [When(@"fills in the requested information to request the service")]
        public void WhenFillsInTheRequestedInformationToRequestTheService(Table table)
        {
            Thread.Sleep(5000);
            // Busca y da click en el input de Output
            var dateInput = webDriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[1]/div/div/div[2]/form/div[2]/div/div/div/input"));
            dateInput.Click();
            dateInput.SendKeys("05052022");
            
            // Busca y da click en el input de persons
            var persons = webDriver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div[1]/div/div/div[2]/form/div[4]/div/div/div/input"));
            persons.Click();
            persons.SendKeys("5");
            
            // Busca y da click en el boton Solicit
            webDriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[1]/div/div/div[2]/div[1]/div/button")).Click();
            
            Thread.Sleep(2500);
            
            
            var creditCard = webDriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div/form/div[2]/div/div/div/input"));
            creditCard.Click();
            creditCard.SendKeys("4556459834142584");
            
            
            var nameOfTheAccountHolder = webDriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div/form/div[3]/div/div/div/input"));
            nameOfTheAccountHolder.Click();
            nameOfTheAccountHolder.SendKeys("Pedrito Sanchez");
            
            var creditCardDate = webDriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div/form/div[4]/div[1]/div/div/div/input"));
            creditCardDate.Click();
            creditCardDate.SendKeys("11/26");
            
            var creditCardCvv = webDriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div/form/div[4]/div[2]/div/div/div/input"));
            creditCardCvv.Click();
            creditCardCvv.SendKeys("631");
            Thread.Sleep(2000);
            
        }

        [Then(@"click on contract")]
        public void ThenClickOnContract()
        {
            webDriver.FindElement(By.XPath("/html/body/div/div[5]/div/div/div/div[2]/button")).Click();
            Thread.Sleep(2000);
            // Click en ok
            webDriver.FindElement(By.XPath("//*[@id='app']/div[7]/div/div/div/button[2]")).Click();
            // Pasos para cerrar sesión
            // Click en menu hamburguesa
            webDriver.FindElement(By.XPath("/html/body/div[1]/div/header/div/div/div[2]/div/button[2]")).Click();
            //Click en Log Out
            Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]")).Click();
            webDriver.Close();
        }


        
    }
    
}