using System.Threading;
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

        [Given(@"click on the agency's website")]
        public void GivenClickOnTheAgencysWebsite()
        {
            // Busca y da click en un servicio que se encuentre disponible
            webDriver.FindElement(By.XPath("/html/body/div/div[1]/main/div/div/div/div[2]/div[1]/div/div[2]/div/div/div")).Click();        }

        [Then(@"in the reviews section you will be able to visualize the valuation of the agency")]
        public void ThenInTheReviewsSectionYouWillBeAbleToVisualizeTheValuationOfTheAgency()
        {
            Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div[2]/div[3]")).Click();
            Thread.Sleep(10000);
            // Pasos para cerrar sesión
            // Click en menu hamburguesa
            webDriver.FindElement(By.XPath("//*[@id='app']/div[1]/header/div/div/div[2]/div/button[2]/span/i")).Click();
            //Click en Log Out
            webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]")).Click();
            webDriver.Close();
        }
    }
}