using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjForTests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjForTestsTest2
{
    [TestClass]
    class CalcTest
    {
        [TestMethod]
        public void Multiplication2And5()
        {
            Calc calc = new Calc();

            int arg1 = 8;
            int arg2 = 5;

            int result = calc.Multiplication(arg1, arg2);

            Assert.Equals(40, result);

        }
    }
}
