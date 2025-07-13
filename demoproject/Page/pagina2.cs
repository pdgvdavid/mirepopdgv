using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace demoproject.Page
{
    public class pagina2
    {

        IWebDriver _driver;
        IWebElement elemento1 => _driver.FindElement(By.LinkText("Add to cart"));
        IWebElement elemento2 => _driver.FindElement(By.LinkText("Cart"));

        IWebElement elemento_table => _driver.FindElement(By.TagName("tbody"));


        public pagina2(IWebDriver driver)
        {
            _driver = driver; 
        }

        public bool presiona_boton_adiciona_cart()
        {
            elemento1.Click();
            //espera 3 segundos 
            //System.Threading.Thread.Sleep(3000);

            //espera por 5 segundos como maximo , si antes de ese tiempo aparece la alerta no espera ese tiempo sino que continua.
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            mipausa.Until( dr =>
            {
                try {
                    _driver.SwitchTo().Alert();
                    return true;
                
                }
                catch (NoAlertPresentException) 
                {
                    return false; 
                }

            
            
            }
            );
            return false;


        }

        public bool presiona_boton_confirmacion_Exito()
        {
            try
            {
                _driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException) { return false; }


        }

        public bool presiona_menu_grabados()
        {
            elemento2.Click();

            bool etiquetaEncontrada = false;

            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            mipausa.Until( dr =>
            { 
            try {
                var rows = elemento_table.FindElements(By.TagName("tr"));

                

                foreach (var row in rows)
                {
                    var columnas = row.FindElements(By.TagName("td"));

                    if (columnas.Count > 0)
                    {
                        // Verifica si la primera columna contiene el texto deseado
                        if (columnas[1].Text.Contains("Sony vaio i7"))
                        {
                            etiquetaEncontrada = true;
                            break;
                        }
                    }
                }
                 //   Console.WriteLine($"valor del bool detalle {etiquetaEncontrada}");

                    return etiquetaEncontrada;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            }
            );
            return etiquetaEncontrada;

        }

    }
}
