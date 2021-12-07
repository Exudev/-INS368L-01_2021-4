using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestVector
{
    [TestClass]
    public class UnitTest1
    {
       
      
        [TestMethod]
        public void TestMagnitude()
        {
            KataVectorsandAngles.Program.Vector vector = new KataVectorsandAngles.Program.Vector(-2, 5);
            double result = vector.Magnitude();
            double esperado = System.Math.Sqrt(29);
            Assert.AreEqual(esperado, result);
        }
        [TestMethod]
        public void TestAngleBet()
        {
            KataVectorsandAngles.Program.Vector vector = new KataVectorsandAngles.Program.Vector(-2, 5);
            KataVectorsandAngles.Program.Vector vector2 = new KataVectorsandAngles.Program.Vector(4, 3);
            //recibido
            double reci = vector2.AngleBetween(vector);
            //esperado
            double esperado = 1.3078015951139772;
            //assert
            Assert.AreEqual(esperado, reci);
        }
        [TestMethod]
        public void TestDot()
        {
            KataVectorsandAngles.Program.Vector vector = new KataVectorsandAngles.Program.Vector(-2, 5);
            KataVectorsandAngles.Program.Vector vector2 = new KataVectorsandAngles.Program.Vector(4, 3);
            double result = vector.DotProduct(vector2);
            int esperado = 7;
            Assert.AreEqual(esperado, result);
        }

    }
}