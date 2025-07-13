using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo.Pages
{
    public class resumen_input
    {

        private IWebDriver _driver; 
        IWebElement botoncheck => _driver.FindElement(By.Id("checkout"));


        public resumen_input(IWebDriver driver)
        {

            _driver = driver;

        }

        public void  espera_carga_resumen()
        {
            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            //mipausa.Until(drv => drv.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")));
            //mipausa.Until(drv => drv.FindElement(By.XPath("//span[text()='Your Cart']")));
            mipausa.Until(drv => drv.FindElement(By.Id("checkout")));
            System.Threading.Thread.Sleep(2000);
        }

        public void presionacheckout()
        {
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)_driver;
            js1.ExecuteScript("window.scrollBy(0, 1000);");
            System.Threading.Thread.Sleep(2000);

            botoncheck.Click();
        }



    }
}
