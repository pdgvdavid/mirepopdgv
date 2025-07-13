using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Dpet
    {
        private IWebDriver _driver;
        IWebElement pezdorado  => _driver.FindElement(By.XPath("//td[text()='Goldfish']/parent::tr/td/a"));
        


        public Dpet(IWebDriver driver)
        {
            _driver = driver;

        }
        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.XPath("//h2[text()='Fish']")));
                                
        }

        public void presiona_goldfish()
        {
            pezdorado.Click();
            

        }



    }
}
