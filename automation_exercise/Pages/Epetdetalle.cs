using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Epetdetalle
    {
        private IWebDriver _driver;
        IWebElement item => _driver.FindElement(By.XPath("//a[text()='EST-21']/parent::td/following-sibling::td/a"));
        

        

        public Epetdetalle(IWebDriver driver)
        {
            _driver = driver;

        }

        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.XPath("//h2[text()='Goldfish']")));

        }

        public void selecciona_gold_detalle()
        {
            item.Click();
            
        
        }

    }
}
