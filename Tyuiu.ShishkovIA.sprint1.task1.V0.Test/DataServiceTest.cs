using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShishkovIA.sprint1.task1.V0.lib;

namespace Tyuiu.ShishkovIA.sprint1.task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);

        }
    }
}