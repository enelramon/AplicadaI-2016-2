using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplicada1_2016_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicada1_2016_2.Tests
{
    [TestClass()]
    public class CalculosTests
    {
        [TestMethod()]
        public void SumarTest()
        {
            Assert.AreEqual(5, Calculos.Sumar(2, 3));
        }

        [TestMethod()]
        public void FactorialTest()
        {
            Assert.AreEqual(1,Calculos.Factorial(0));
        }
    }
}