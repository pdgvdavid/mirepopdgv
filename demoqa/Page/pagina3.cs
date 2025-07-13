using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa.Page
{
    public class pagina3
    {
        private IWebDriver _driver;
        IWebElement nombre => _driver.FindElement(By.Id("firstName"));
        IWebElement apellido => _driver.FindElement(By.Id("lastName"));
        IWebElement email => _driver.FindElement(By.Id("userEmail"));
        IWebElement telefono => _driver.FindElement(By.Id("userNumber"));
        IWebElement fechanac => _driver.FindElement(By.Id("dateOfBirthInput"));
        IWebElement temas => _driver.FindElement(By.Id("subjectsInput"));
        IWebElement direccion => _driver.FindElement(By.Id("currentAddress"));
        IWebElement genero => _driver.FindElement(By.Id("gender-radio-1"));
        //IWebElement pasatiempo => _driver.FindElement(By.XPath("//label[text()='Sports']"));
        IWebElement pasatiempo => _driver.FindElement(By.Id("hobbies-checkbox-1"));

        IWebElement botonenviar => _driver.FindElement(By.Id("submit"));


        IWebElement botonclose => _driver.FindElement(By.Id("closeLargeModal"));

        IWebElement estado => _driver.FindElement(By.Id("state"));
        IWebElement ciudad => _driver.FindElement(By.Id("city"));





        public pagina3(IWebDriver driver)
        {

            _driver = driver; 
        }

        public void ingresa_datos()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;

            nombre.SendKeys("percy");
            apellido.SendKeys("garcia");
            email.SendKeys("pgarcia@gmail.com");
            telefono.SendKeys("9419389400");
            //fechanac.SendKeys("01/01/2025");
            js.ExecuteScript("arguments[0].value = '19 Jun 2024';",fechanac);

            
            estado.Click();
            //_driver.FindElement(By.XPath("//div[contains(@id, 'react-select-3-option-2')]")).Click();
            IWebElement combo1 = _driver.FindElement(By.XPath("//div[contains(text(), 'Haryana')]"));
            js.ExecuteScript("arguments[0].click();", combo1);

           
            ciudad.Click();
            //      _driver.FindElement(By.XPath("//div[contains(@id, 'react-select-4-option-1')]")).Click();
            IWebElement combo2 = _driver.FindElement(By.XPath("//div[contains(text(), 'Panipat')]"));
            js.ExecuteScript("arguments[0].click();", combo2);


            temas.SendKeys("observacion general");
            direccion.SendKeys("ex fundo marquez");

            js.ExecuteScript("arguments[0].click();", pasatiempo);
            js.ExecuteScript("arguments[0].click();", genero);
            System.Threading.Thread.Sleep(10000);
            js.ExecuteScript("arguments[0].click();", botonenviar);
            System.Threading.Thread.Sleep(10000);

            WebDriverWait mipausa = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            mipausa.Until(dr =>
            {
                try
                {
                    _driver.SwitchTo().ActiveElement();// Alert();
                    return true;

                }
                catch (NoAlertPresentException)
                {
                    return false;
                }



            }
            );


            js.ExecuteScript("arguments[0].click()", botonclose);


        }






    }
}
