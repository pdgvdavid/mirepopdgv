using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Gdatos
    {
        private IWebDriver _driver;
        IWebElement nombre => _driver.FindElement(By.Name("order.billToFirstName"));
        IWebElement apellido => _driver.FindElement(By.Name("order.billToLastName"));
        IWebElement direccion => _driver.FindElement(By.Name("order.billAddress1"));
        IWebElement boton_continuar => _driver.FindElement(By.Name("newOrder"));



        public Gdatos(IWebDriver driver)
        {
            _driver = driver;
        
        }

        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.Name("newOrder")));

        }

        public void completa_datos()
        {
            nombre.Clear();
            apellido.Clear();
            direccion.Clear();
            nombre.SendKeys("Percy David");
            apellido.SendKeys("Garcia Villarroel");
            direccion.SendKeys("Ex fundo Marquez");
            boton_continuar.Click();
        
        }


    }
}
