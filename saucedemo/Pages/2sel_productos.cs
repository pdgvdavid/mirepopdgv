using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo.Pages
{
    public class sel_productos
    {
        private IWebDriver _driver;
        IWebElement articulo1 => _driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        IWebElement articulo2 => _driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        IWebElement articulo3 => _driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        IWebElement articulo4 => _driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));

        IWebElement carrito => _driver.FindElement(By.ClassName("shopping_cart_link"));



        public sel_productos(IWebDriver driver)
        {
            _driver = driver; 

        }

        public void espera_carga_sel()
        {
           // acepta_dialogo();
            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            //mipausa.Until(drv => drv.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")));
            mipausa.Until(drv => drv.FindElement(By.XPath("//div[text()='Test.allTheThings() T-Shirt (Red)']")));

        }

        public void Selecciona()
        {
            articulo1.Click();
            articulo2.Click();
            articulo3.Click();
            articulo4.Click();
            System.Threading.Thread.Sleep(1000);
            carrito.Click();

        }

        public bool acepta_dialogo()
        {
            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(7));
            mipausa.Until(dr =>
            {
                try
                {
                    _driver.SwitchTo().ActiveElement();
                    return true;

                }
                catch (NoAlertPresentException)
                {
                    return false;
                }



            }
           );
            return true;

        }

    }
}
