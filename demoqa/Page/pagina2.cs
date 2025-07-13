using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa.Page
{
    public class pagina2
    {
        private IWebDriver _driver;

        IWebElement botonpractice => _driver.FindElement(By.XPath("//div[@class='element-list collapse show']//li[@id='item-0']//span[text()='Practice Form']")); 
        public pagina2( IWebDriver driver)
        {
            _driver = driver; 
        }

        public void presiona_practice_form()
        {
            botonpractice.Click();
            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(dr => dr.FindElement(By.Id("firstName")).Displayed);
        
        }

        public bool ubica_objeto_field()
        {

            return _driver.FindElement(By.Id("firstName")).Displayed;
        }




    }
}
