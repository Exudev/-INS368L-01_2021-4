using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingDoor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOpen(Door.Program.Door door)
        {
            bool reci = door.Open(door);
            bool esperado = true;
            Assert.AreEqual(esperado, reci);
        }
        [TestMethod]
        public void TestClose(Door.Program.Door door)
        {
            bool reci = door.Open(door);
            bool esperado = false;
            Assert.AreEqual(esperado, reci);
        }
       
    }
}
