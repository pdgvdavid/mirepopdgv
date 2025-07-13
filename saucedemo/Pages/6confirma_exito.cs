using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo.Pages
{
    public class confirma_exito
    {
        IWebDriver _driver;

        public confirma_exito(IWebDriver driver)
        {
            _driver = driver; 

        }

        public bool espera_carga_confirmacion()
        {
            bool mivar = false;
             
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var mielemento = mipausa.Until(
                
                dr => dr.FindElement(By.XPath("//span[text()='Checkout: Complete!']"))
                
                );

            mivar = mielemento.Displayed;

            return mivar;

        }

    }
}
