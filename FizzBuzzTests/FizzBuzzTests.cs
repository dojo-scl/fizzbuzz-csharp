using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void PrintFizzWhen3()
        {
            var numero = 3;
            Assert.AreEqual("Fizz", Program.EvaluaFizzBuzz(numero));
        }
        [TestMethod]
        public void PrintNoFizzWhen5()
        {
            var numeroNo = 5;
            Assert.AreNotEqual("Fizz", Program.EvaluaFizzBuzz(numeroNo));
        }
    }
}
