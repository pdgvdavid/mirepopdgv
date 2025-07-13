using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo.Pages
{
    public class resumen_final
    {
        private IWebDriver _driver;
        IWebElement boton => _driver.FindElement(By.Id("finish"));

        public resumen_final(IWebDriver driver)
        {
            _driver = driver; 
        }

        public void espera_carga_refinal()
        {
            WebDriverWait pausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            pausa.Until(dr => dr.FindElement(By.XPath("//span[text()='Checkout: Overview']")));
        
        }

        public void presiona_boton_final()
        {
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)_driver;
            js1.ExecuteScript("window.scrollBy(0, 1000);");
            System.Threading.Thread.Sleep(2000);
            boton.Click();
        }


    }
}
