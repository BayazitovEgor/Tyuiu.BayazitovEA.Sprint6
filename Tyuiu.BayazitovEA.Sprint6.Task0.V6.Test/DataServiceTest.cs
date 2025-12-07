using Tyuiu.BayazitovEA.Sprint6.Task0.V6.Lib;
namespace Tyuiu.BayazitovEA.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds =  new DataService();
            double res = ds.Calculate(3);
            double wait = 1 ;
            Assert.AreEqual(wait, res);
        }
    }
}
