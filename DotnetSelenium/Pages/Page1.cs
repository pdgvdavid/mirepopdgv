using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V135.Network;

namespace DotnetSelenium.Pages
{
    public class Page1
    {
        private readonly IWebDriver driver;

        public Page1(IWebDriver driver)
            {
            this.driver = driver; 
        }

       
        IWebElement datainput => driver.FindElement(By.Name("q"));

        
        public void busqueda()
        {
            datainput.SendKeys("Selenium");
            datainput.SendKeys(Keys.Return);
            

        }

    }
}
