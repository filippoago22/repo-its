using Calcolatrice_lb;
    namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            Calcolatrice_lb.Calcolatrice calcolatrice = new Calcolatrice_lb.Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, "La somma di 2 e 3 dovrebbe essere 5.");
        }
    }
}
