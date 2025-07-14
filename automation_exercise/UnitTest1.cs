using automation_exercise.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace automation_exercise
{
    public class Tests


    {
        private IWebDriver _driver;
        

        [SetUp]
        public void Setup()
        {

            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("https://petstore.octoperf.comapdgv/");
            _driver.Manage().Window.Maximize();

            

        }

        //https://automationexercise.com/
        //https://practice.expandtesting.com/
        //https://testpages.eviltester.com/styled/index.html
        //https://techbeamers.com/websites-to-practice-selenium-webdriver-online/
        //https://opensource-demo.orangehrmlive.com/web/index.php/auth/login
        //https://petstore.octoperf.com/



        [Test]
        public void Test1()
        {

            var pagina_inicial = new Ainicial(_driver);
            pagina_inicial.espera_carga_pagina();
            pagina_inicial.presiona_link();

            var pagina_acciones = new Bacciones(_driver);
            pagina_acciones.espera_carga_pagina();
            pagina_acciones.presiona_signin();


            var pagina_logueo = new Clogueo(_driver);
            pagina_logueo.espera_carga_pagina();
            pagina_logueo.presiona_login();
            pagina_logueo.espera_logueado_exitoso();
            pagina_logueo.accede_fish();

            var pagina_pet = new Dpet(_driver);
            pagina_pet.espera_carga_pagina();
            pagina_pet.presiona_goldfish();

            var pet_item = new Epetdetalle(_driver);
            pet_item.espera_carga_pagina();
            pet_item.selecciona_gold_detalle();

            var cart_resumen = new Fcart(_driver);
            cart_resumen.espera_carga_pagina();
            cart_resumen.ingresa_cantidad();

            var cart_datos = new Gdatos(_driver);
            cart_datos.espera_carga_pagina();
            cart_datos.completa_datos();

            var pagina_confirma = new Hresumen(_driver);
            pagina_confirma.espera_carga_pagina();
            pagina_confirma.confirma();

            System.Threading.Thread.Sleep(5000);
            Assert.Fail();
        }


        [TearDown]
        public void cierraTodo()
        {
            if (_driver != null)
            {

                _driver.Quit();
                _driver.Dispose();
            
            }
        
        }





    }
}