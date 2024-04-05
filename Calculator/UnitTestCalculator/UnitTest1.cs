using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c;
        public TestContext TestContext
        {
            get;
            set;
        }
        [TestInitialize]
        public void SetUp()
        {
            c = new Caculation(10, 5);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TextData.csv", "TextData#csv", DataAccessMethod.Sequential)]
        public void TestDataWithSource()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            Caculation c = new Caculation(a, b);
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}