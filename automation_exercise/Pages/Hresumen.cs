using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Hresumen
    {

        private IWebDriver _driver;
        IWebElement boton => _driver.FindElement(By.LinkText("Confirm"));



        public Hresumen(IWebDriver driver)
        {
            _driver = driver;

        }

        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.XPath("//div[contains(text(),'Please confirm')]")));

        }

        public void confirma()
        {
            boton.Click();
        }




    }
}
