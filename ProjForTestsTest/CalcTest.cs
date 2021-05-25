using System;
using System.Collections.Generic;
using System.Text;
using ProjForTests;
using Xunit;

namespace ProjForTestsTest
{
    public class CalcTest
    {
        [Fact]
        public void Multiplication2And5()
        {
            Calc calc = new Calc();
            int arg1 = 2;
            int arg2 = 5;

            int result = calc.Multiplication(arg1, arg2);

            Assert.Equal(10, result);

        }
    }
}
