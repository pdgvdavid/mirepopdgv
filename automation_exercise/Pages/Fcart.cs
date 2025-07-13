using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace automation_exercise.Pages
{
    public class Fcart
    {
        private IWebDriver _driver;
        IWebElement input1 => _driver.FindElement(By.XPath("//a[text()='Remove']/parent::td/parent::tr/td/following-sibling::td/input"));

        IWebElement subtotal => _driver.FindElement(By.XPath("//td[contains(text(), 'Sub Total')]"));

        IWebElement boton_actualizar => _driver.FindElement(By.Name("updateCartQuantities"));

        
        IWebElement boton1 => _driver.FindElement(By.LinkText("Proceed to Checkout"));
        


        public Fcart(IWebDriver driver)
        {
            _driver = driver;
        
        }

        public void espera_carga_pagina()
        {

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(drv => drv.FindElement(By.XPath("//h2[text()='Shopping Cart']")));

        }

        public void ingresa_cantidad()
        {
            input1.Clear();
            input1.SendKeys("3");
            var valor_original = subtotal.Text;
            boton_actualizar.Click();

            var mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until( dr1 =>
               {
                return valor_original != subtotal.Text;
            } 
               
                );
            //System.Threading.Thread.Sleep(1000);
            boton1.Click();
        
        }

    }

}
