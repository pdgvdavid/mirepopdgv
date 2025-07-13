using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public static class SeleniumCustomMethods
    {


        public static void Click_Especial(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }

        public static void Ingresa_texto(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }

        public static void Ingresa_texto2( this IWebElement locator, string txt1)
        {
            locator.SendKeys(txt1);
        }


        public static void muestra_texto_lista(IWebDriver driver, By locator, string[] values)
        {
            SelectElement multiSelect = new SelectElement(driver.FindElement(locator));

            foreach (var valor in values)
            {
                multiSelect.SelectByValue(valor);
            }
            

        }



    }
}
