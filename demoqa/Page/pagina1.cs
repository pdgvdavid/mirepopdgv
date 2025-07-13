using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa.Page
{
    public class pagina1
    {
        private IWebDriver _driver;
        //IWebElement elemento1 => _driver.FindElement(By.XPath("//h5[text()='Forms']/ancestor::div[@class='card mt-4 top-card']"));
        IWebElement elemento1 => _driver.FindElement(By.XPath("//div[@class='card-body']/h5[text()='Forms']/.."));
        public pagina1(IWebDriver driver )
        {
            _driver = driver; 
        
        }

        public void selecciona_boton_forms()
        {
            elemento1.Click();
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until( dr => dr.FindElement(By.ClassName("accordion")));
        }




    }
}
