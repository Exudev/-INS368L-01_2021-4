using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingTemperature
{
    [TestClass]
    public class UnitTest1
    {
        //probando conversiones desde Fah
        [TestMethod]
        public void TestFahToCel()
        {
            TemperatureApp.Program.Temperature temp = new TemperatureApp.Program.Temperature("F",32);
            double CelDado = TemperatureApp.Program.Temperature.FahToCel(temp);
            double esperado = 0.0;
            Assert.AreEqual(esperado,CelDado);
        }
        [TestMethod]
        public void TestFahToKel()
        {
            TemperatureApp.Program.Temperature temp = new TemperatureApp.Program.Temperature("F", 32);
            double KelDado = TemperatureApp.Program.Temperature.FahToKel(temp);
            double esperado = 273.15;
            Assert.AreEqual(esperado, KelDado);
        }
        //probando conversiones desde Cel
        [TestMethod]
        public void TestCelToKel()
        {
            TemperatureApp.Program.Temperature temp = new TemperatureApp.Program.Temperature("C", 2);
            double KelDado = TemperatureApp.Program.Temperature.CelToKel(temp);
            double esperado = 275.15;
            Assert.AreEqual(esperado, KelDado);
        }
        [TestMethod]
        public void TestCelToFah()
        {
            TemperatureApp.Program.Temperature temp = new TemperatureApp.Program.Temperature("C", 2);
            double FahDado = TemperatureApp.Program.Temperature.CelToFah(temp);
            double esperado = 35.6;
            Assert.AreEqual(esperado, FahDado);
        }
        //probando conversiones desde Kel
        [TestMethod]
        public void TestKelToFah()
        {
            TemperatureApp.Program.Temperature temp = new TemperatureApp.Program.Temperature("K", 10);
            double FahDado = TemperatureApp.Program.Temperature.KelToFah(temp);
            double esperado = -441.66999999999996;
            Assert.AreEqual(esperado, FahDado);
        }
        [TestMethod]
        public void TestKelToCel()
        {
            TemperatureApp.Program.Temperature temp = new TemperatureApp.Program.Temperature("K", 5);
            double CelDado = TemperatureApp.Program.Temperature.KelToCel(temp);
            double esperado = -268.15;
            Assert.AreEqual(esperado, CelDado);
        }
    }
}
