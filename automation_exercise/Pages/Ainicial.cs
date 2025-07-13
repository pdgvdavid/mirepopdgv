using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Ainicial
    {
        private IWebDriver _driver;
        IWebElement linkentrar => _driver.FindElement(By.LinkText("Enter the Store"));


        public Ainicial(IWebDriver driver)
        {
            _driver = driver;
        }

        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.LinkText("Enter the Store")));
        }

        public void presiona_link()
        {
            linkentrar.Click();
        }

    }
}
