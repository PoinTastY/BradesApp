using BradesAppTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Infrastructure;

namespace BradesAppTest.StepDefinitions
{
    [Binding]
    public sealed class BradesAppStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private AppiumDriver<AndroidElement> _driver;
        //private readonly ISpecFlowOutputHelper specFlowOutputHelper; use 4 later
        //adb uninstall io.appium.uiautomator2.server.test adb uninstall io.appium.uiautomator2.server
        readonly TestingDriver driver;

        public BradesAppStepDefinitions()
        {
            driver = (TestingDriver)ScenarioContext.Current["driver"];
            _driver = driver.Init();

        }

        [Given(@"Ejecuto la aplicacion")]
        public void GivenEjecutoLaAplicacion()
        {

            //_driver = driver.Init();
            Gestos.SwipeTopRight(_driver);
            try
            {
                _driver.FindElementByAccessibilityId("bradescard").Click();
            }
            catch { }
            Thread.Sleep(3000);
        }

        [Then(@"Espero el siguiente escenario")]
        public void ThenEsperoElSiguienteEscenario()
        {
        }

        [Given(@"Abro el menu oculto")]
        public void GivenAbroElMenuOculto()
        {
            //_driver = driver.Init();
            _driver.FindElementByAccessibilityId("Menú").Click();
            
        }

        [Given(@"Doy Click en Leyendas Legales")]
        public void GivenDoyClickEnLeyendasLegales()
        {
            try
            {
                _driver.FindElementById("mx.com.appbradescard:id/txtLegalLegends").Click();

            }catch (Exception ex)
            {
            }
        }

        [Given(@"Voy a Aviso Legal")]
        public void GivenVoyAAvisoLegal()
        {
            try
            {
                _driver.FindElementByAccessibilityId("Aviso Legal").Click();
            }catch (Exception ex)
            {
            }
        }

        [Given(@"Voy a Aclaraciones")]
        public void GivenVoyAAclaraciones()
        {
            try
            {
                _driver.FindElementByAccessibilityId("Aclaraciones").Click();
            }
            catch { }
        }

        [Then(@"Regreso al inicio de sesion")]
        public void ThenRegresoAlInicioDeSesion()
        {
            _driver.Navigate().Back();
        }

        [Given(@"Doy Click en Ayuda")]
        public void GivenDoyClickEnAyuda()
        {
            //_driver = driver.Init();

            _driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"mx.com.appbradescard:id/txtHelp\"]").Click();
        }

        [Given(@"Doy click en Chat")]
        public void GivenDoyClickEnChat()
        {
            Thread.Sleep(1000);
            _driver.FindElementByAccessibilityId("Chat").Click();
        }

        [Given(@"Doy click en Telefono")]
        public void GivenDoyClickEnTelefono()
        {
            _driver.FindElementByAccessibilityId("Teléfono").Click();
        }


        //[Given(@"Ingreso la tarjeta y la password")]
        //public void GivenIngresoLaTarjetaYLaPassword(Table table)
        //{
        //    dynamic data = table.CreateDynamicInstance();
        //    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
        //    try
        //    {
        //        _driver.FindElementById("mx.com.appbradescard:id/inputCard").Click();

        //        jsExecutor.ExecuteScript("mobile: shell", new Dictionary<string, string>
        //        {
        //            { "command", $"input text {data.tarjeta}" }
        //        });
        //    }
        //    catch(NoSuchElementException ex)
        //    {
        //        Console.WriteLine($"Usuario prevbiamente loggeado: {ex}");
        //    }

        //    _driver.FindElementById("mx.com.appbradescard:id/inputPassword").Click();

        //    jsExecutor.ExecuteScript("mobile: shell", new Dictionary<string, string>
        //    {
        //        { "command", $"input text {data.password}" }
        //    });

        //    _driver.HideKeyboard();

        //    _driver.FindElementById("mx.com.appbradescard:id/btnLogin").Click();
        //}

        //[Then(@"Espero el siguiente escenario")]
        //public void ThenEsperoElSiguienteEscenario()
        //{
        //    Thread.Sleep(3000);
        //}

        //[Given(@"Tomo la captura de la primera aparicion")]
        //public void GivenTomoLaCapturaDeLaPrimeraAparicion()
        //{
        //    Thread.Sleep(3000);
        //    try
        //    {
        //        _driver.GetScreenshot().SaveAsFile("C:\\Users\\kbece\\source\\repos\\QATester\\Evidencies\\Resta.png");
        //    }
        //    catch { }
        //}

        //[Given(@"Navego a la siguiente y capturo")]
        //public void GivenNavegoALaSiguienteYCapturo()
        //{
        //    Gestos.SwipeTopRight(_driver);
        //    Thread.Sleep(1000);
        //    try
        //    {
        //        _driver.GetScreenshot().SaveAsFile("C:\\Users\\kbece\\source\\repos\\QATester\\Evidencies\\Resta.png");

        //    }
        //    catch { }

        //}

        //[Then(@"Espero el ultimo escenario")]
        //public void ThenEsperoElUltimoEscenario()
        //{
        //    Thread.Sleep(1000);
        //}

        //[Given(@"Voy a notificaciones")]
        //public void GivenVoyANotificaciones()
        //{
        //    Thread.Sleep(3000);
        //    try
        //    {
        //        _driver.FindElementById("mx.com.appbradescard:id/notifications").Click();
        //    }catch (Exception ex) { }
        //}

        //[Given(@"regreso a la vista anterior")]
        //public void GivenRegresoALaVistaAnterior()
        //{
        //    try
        //    {
        //        _driver.Navigate().Back();
        //    }
        //    catch { }
        //    Thread.Sleep(1000);
        //}

        //[Given(@"voy a ayuda")]
        //public void GivenVoyAAyuda()
        //{
        //    try
        //    {
        //        _driver.FindElementById("mx.com.appbradescard:id/txtHelp").Click();

        //    }catch(Exception ex) { }
        //}

        //[Then(@"me salgo de la aplicacion")]
        //public void ThenMeSalgoDeLaAplicacion()
        //{
        //    try
        //    {
        //        _driver.Navigate().Back();
        //        _driver.Navigate().Back();
        //        _driver.Navigate().Back();
        //    }catch { }
        //}

    }
}
