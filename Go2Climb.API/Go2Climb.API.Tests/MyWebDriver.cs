using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Go2Climb.API.Tests
{
    public class MyWebDriver
    {
        public static WebDriver webDriver;

        private MyWebDriver()
        {
            
        }

        public static WebDriver getWebdriver()
        {
            if (webDriver == null)
            {
                //string urlPage = "https://www.google.com";
                // Establece el chrome driver
                //WebDriver webDriver;
                string pathDriver = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + "\\Driver" ;
                
                webDriver = new ChromeDriver(@pathDriver);

                // Carga la pagina
                webDriver.Navigate().GoToUrl("https://www.google.com");

                // --Maximiza la ventana
                webDriver.Manage().Window.Maximize();
            }

            return webDriver;
        }
    }
     
}