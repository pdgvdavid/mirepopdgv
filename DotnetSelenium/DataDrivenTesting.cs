using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Script;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class DataDrivenTesting
    {
        private IWebDriver _driver; 

        [SetUp]
        public void Setup()
        {

            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("C:\\vs\\vs2022\\mipagina.html");
            _driver.Manage().Window.Maximize();
            


        }

        [Test]
        [TestCaseSource(nameof(modelo_1))]
        public void Test1_case_source(ModelValor modelo2)
        {
            IWebElement elemento1 = _driver.FindElement(By.Name("codigo"));
            elemento1.SendKeys(modelo2.name);
            Console.WriteLine(modelo2.name);

           //  WebDriverWait espera1 = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            ///espera1.Until(dr => dr.FindElement(By.Name("tt")));
        }

        // este metodo modelo() es invocado desde el test Test1_case_source
        public static IEnumerable<ModelValor> modelo_1()
        {
            yield return new ModelValor() { name = "valor1" };
            yield return new ModelValor() { name = "valor2" };
        }


        [Test]
        [TestCaseSource(nameof(modelo_2))]
        public void Test1_archivojson(ModelValor dato )
        {
            
            IWebElement elemento1 = _driver.FindElement(By.Name("codigo"));
            elemento1.SendKeys(dato.name);
            Console.WriteLine($"dato desde json {dato.name} ");

            //            WebDriverWait espera1 = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            //espera1.Until(dr => dr.FindElement(By.Name("tt")));

            IWebElement elemento2 = _driver.FindElement(By.Name("txtcodigo2"));

            Assert.IsTrue(elemento2.Displayed);
        }

        // este metodo modelo() es invocado desde el test Test1_archivojson
        public static IEnumerable<ModelValor> modelo_2()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.json");
            var jsonString = File.ReadAllText(jsonFilePath);
            var dato = JsonSerializer.Deserialize<List<ModelValor>>(jsonString);

            foreach (var registro1 in dato)
            {
                yield return registro1;
            }

        }

        // uso de tuples, cuando un metodo en este caso verifica_existe_objeto() retorna mas de 1 valor
        [Test]
        public void Test1_tuples()
        {

            var getval = verifica_existe_objeto();

            Assert.IsTrue( getval.primer_valor && getval.segundo_valor && getval.tercer_valor);
        }


        public (bool primer_valor, bool segundo_valor, bool tercer_valor) verifica_existe_objeto()
        {
            IWebElement elemento1 = _driver.FindElement(By.Name("codigo"));
            IWebElement elemento2 = _driver.FindElement(By.Name("txtcodigo2"));
            IWebElement elemento3 = _driver.FindElement(By.Name("miboton"));
            return (elemento1.Displayed, elemento2.Displayed, elemento3.Displayed);
        }


        /*
        private void ReadJsonFile()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.json");
            var jsonString = File.ReadAllText(jsonFilePath);
            var dato = JsonSerializer.Deserialize<ModelValor>(jsonString);
            Console.WriteLine($"valor de json : { dato.name}");

        }
        */

        [TearDown]
        public void Libera()
        {
            _driver.Quit();
            _driver.Dispose();

        }

    }
}
