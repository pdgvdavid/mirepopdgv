using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
       
        }

        [Test]
        public void Test_controles_basicos()
        {
            // Assert.Pass();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);
        }

        [Test]
        public void Test_controles_avanzados()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("C:\\vs\\vs2022\\mipagina.html");
            driver.Manage().Window.Maximize();

            // para usar la clase selectElement se tuvo que instalar el package Selenium.Suport para manipular el combo box.
            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("dropdown")));
            selectElement.SelectByText("option_2");

            //usando la clase select para un control de seleccion multiple
            SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("multiselect")));
            multiSelect.SelectByValue("optionm2");
            multiSelect.SelectByValue("optionm3");

            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;

            foreach(IWebElement option in selectedOption)
            {
                Console.WriteLine(option.Text);
            }


            //usando la clase select para otro control de seleccion multiple pero usando un metodo personalizado.
            SeleniumCustomMethods.muestra_texto_lista(driver, By.Id("multiselectper"), ["optionp1", "optionp2"]);

            // seteando un texto usando el metodo personalizado
            SeleniumCustomMethods.Ingresa_texto(driver, By.Name("codigo"), "dato de testing");


            //extension de metodo : method extension. 
            IWebElement txtcodigo2 = driver.FindElement(By.Name("txtcodigo2"));
            txtcodigo2.Ingresa_texto2("method extension"); 
// este metodo Ingresa_texto2 esta en la clase SeleniumCustomMethod y como tiene la palabra this en el parametro IWebElement hace que el metodo Ingresa_texto2
// sea una extension de IWebElement.



            //IWebElement boton = driver.FindElement(By.Id("miboton"));

            // presionando el boton usando el metodo personalizado
            SeleniumCustomMethods.Click_Especial(driver, By.Name("miboton"));

            
            
        }



        [Test]
        public void Test_POM()

        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

            var clase_page1 = new Page1(driver);
            clase_page1.busqueda();

        }

    }
}