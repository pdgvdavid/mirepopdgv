using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Bacciones
    {
        private IWebDriver _driver;
        IWebElement linksingin => _driver.FindElement(By.LinkText("aaaaaign In"));

        public Bacciones(IWebDriver driver)
        {
            _driver = driver;
        }
        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.LinkText("Sign In")));
        }

        public void presiona_signin()
        {
            linksingin.Click();
        }


    }


}
