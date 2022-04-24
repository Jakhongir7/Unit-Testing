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
    public class PrimeFactorTests
    {
        [TestMethod()]
        public void CheckPrimeCompositeTest_Input_One()
        {
            string result = PrimeFactor.CheckPrimeComposite(1);

            Assert.AreEqual(result, "1");
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod()]
        public void CheckPrimeCompositeTest_Input_Zero()
        {
             PrimeFactor.CheckPrimeComposite(0);
        }
    }
}