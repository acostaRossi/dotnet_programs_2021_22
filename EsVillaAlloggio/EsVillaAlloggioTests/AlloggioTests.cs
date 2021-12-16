using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EsVillaAlloggio.Tests
{
    [TestClass()]
    public class AlloggioTests
    {
        [TestMethod()]
        public void AlloggioTest()
        {
            Alloggio al = new Alloggio("abc", 2, 10);
            
            double risultato = al.CostoAcqua(5);
            Assert.AreEqual(10, risultato);
        }
    }
}