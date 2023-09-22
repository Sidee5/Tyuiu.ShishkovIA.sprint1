using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShishkovIA.sprint1.task0.V0.lib;

namespace Tyuiu.ShishkovIA.sprint1.task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15, res);
        }
    }
}
