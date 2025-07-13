using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject.Page
{
    public class pagina1
    {
        private IWebDriver _driver;
        IWebElement elemento1 => _driver.FindElement(By.LinkText("Laptops"));
        IWebElement elemento2 => _driver.FindElement(By.LinkText("Sony vaio i7"));

        public pagina1(IWebDriver driver)
        {
            _driver = driver; 
        }

        public void muestra_solo_notebooks()
        {
            elemento1.Click();
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //mipausa.Until(dr => dr.FindElement(By.LinkText("Sony vaio i7")));
            
            mipausa.Until(dr => {
                //try { var existe = dr.FindElement(By.LinkText("Sony vaio i7")); return existe.Displayed; }
                try { return dr.FindElement(By.LinkText("Sony vaio i7")).Displayed;  }
                catch (NoSuchElementException)
                {
                    return false;
                }
            
            
            });
            


        }

        public bool seleccionar_vaio7()
        {

            elemento2.Click();
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //mipausa.Until(dr => dr.FindElement(By.LinkText("Add to cart")));
            mipausa.Until(dr =>
            { 

                try {
                var element1 = _driver.FindElement(By.LinkText("Add to cart"));
                return element1.Displayed;
                    }
            catch (NoSuchElementException) 
                    {
                return false;
                    }
            }
                
            );

            return false;

        }



    }
}
