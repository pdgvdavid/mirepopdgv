using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V136.Audits;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Clogueo
    {

        private IWebDriver _driver;
        IWebElement usuario => _driver.FindElement(By.Name("username"));
        
        IWebElement botonconectar => _driver.FindElement(By.Name("signon"));

        IWebElement peces => _driver.FindElement(By.XPath ("//div[@Id='SidebarContent']/a/img"));

        public Clogueo(IWebDriver driver)
        {
            _driver = driver;
        }
        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.Name("signon")));
        }

        public void presiona_login()
        {
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)_driver; 

            usuario.SendKeys("pdgv");
            
            js1.ExecuteScript("document.getElementsByName('password')[0].value='pdgv'");
           // clave.SendKeys("pdgv");
            botonconectar.Submit();

        }

        public void espera_logueado_exitoso()
        {
            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.LinkText("Sign Out")));
        
        }

        public void accede_fish() 
        {
            peces.Click();
        }



    }
}
