﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.ShishkovIA.sprint1.task2.V26.lib;

namespace Tyuiu.ShishkovIA.sprint1.task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5; int y = 16;
            int res = ds.CalculateMinutesSinceStart(x, y);
            Assert.AreEqual(316, res);
        }
    }
}
