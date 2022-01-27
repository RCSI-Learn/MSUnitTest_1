using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSUnitTestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest {
    [TestClass]
    public class CalcTest {
        [DataRow(4, 4, 8)]
        [DataRow(5, 5, 10)]
        [DataRow(2, 3, 5)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue(int a, int b, int expected) {
            //Arrange
            //int a = 4;
            //int b = 4;
            //int expected = 8;
            //Act
            int actual = Calc.Sum(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
