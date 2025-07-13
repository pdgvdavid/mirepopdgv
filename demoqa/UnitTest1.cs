using demoqa.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace demoqa
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddUserProfilePreference("profile.default_content_setting_values.images", 2); // No cargar imágenes
            //IWebDriver 
            //    driver = new ChromeDriver(options);


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {



                        var pagina1 = new pagina1(driver);
                      pagina1.selecciona_boton_forms();
                    var pagina2 = new pagina2(driver);
                  pagina2.presiona_practice_form();





                var pagina3 = new pagina3(driver);
               pagina3.ingresa_datos();



            Assert.IsTrue(pagina2.ubica_objeto_field());
        }

        [TearDown]
        public void Cierratodo()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();

            }

        }

    }
}