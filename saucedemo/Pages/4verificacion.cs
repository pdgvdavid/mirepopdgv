using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo.Pages
{
    public class verificacion
    {
        private IWebDriver _driver;
        IWebElement nombre => _driver.FindElement(By.Id("first-name"));
        IWebElement apellido => _driver.FindElement(By.Id("last-name"));

        IWebElement codpostal => _driver.FindElement(By.Id("postal-code"));

        IWebElement boton => _driver.FindElement(By.Id("continue"));

        public verificacion(IWebDriver driver)
        {

            _driver = driver; 
        }


        public void espera_carga_verificar()
        {
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(dr => dr.FindElement(By.XPath("//span[text()='Checkout: Your Information']")));

        }

        public void presiona_continuar()
        {
            nombre.SendKeys("percy");
            apellido.SendKeys("garcia");
            codpostal.SendKeys("12456");
            System.Threading.Thread.Sleep(2000);
            boton.Click();
        }
    }
}
