using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing.Tasks.Tests
{
    [TestClass()]
    public class OddEvenTests
    {
        [DataRow(1, "Odd")]
        [DataRow(15, "Odd")]
        [DataRow(27, "Odd")]
        [DataRow(33, "Odd")]
        [DataRow(81, "Odd")]
        [TestMethod()]
        public void Should_Be_Odd(int num, string result)
        {
            Assert.AreEqual(OddEven.CheckOddEven(num), result);
        }

        [DataRow(2, "Even")]
        [DataRow(4, "Even")]
        [DataRow(10, "Even")]
        [DataRow(82, "Even")]
        [DataRow(100, "Even")]
        [TestMethod()]
        public void Should_Be_Even(int num, string result)
        {
            Assert.AreEqual(OddEven.CheckOddEven(num), result);
        }

        [DataRow(3, "Prime")]
        [DataRow(7, "Prime")]
        [DataRow(11, "Prime")]
        [DataRow(17, "Prime")]
        [DataRow(73, "Prime")]
        [TestMethod()]
        public void Should_Be_Prime(int num, string result)
        {
            Assert.AreEqual(OddEven.CheckOddEven(num), result);
        }

        [DataRow(-5)]
        [DataRow(104)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod()]
        public void Should_Throw_ArgumentOutOfRangeException_If_Input_OutOfRange(int num)
        {
            OddEven.CheckOddEven(num);
        }
    }
}