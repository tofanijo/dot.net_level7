using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pvz1;

namespace pvz1.test
{
    [TestClass]
    public class taxTest
    {
        [TestMethod]
        public void TaxShov1dBeSpercent40000()
        {
            // Arange (paruost)

            //Act (patikrint)
            decimal result = Program.Tax(40000);
            //Assert (ivykdit)
            Assert.AreEqual(result, 2000);
        }



        [TestMethod]

        public void TaxShov1dBeSpercent100000()
        {
            // Arange (paruost)

            //Act (patikrint)
            decimal result = Program.Tax(100000);
            //Assert (ivykdit)
            Assert.AreEqual(result, 15000);

        }
        [TestMethod]

        public void TaxShov1dBeSpercent250000()
        {
            // Arange (paruost)

            //Act (patikrint)
            decimal result = Program.Tax(150000);
            //Assert (ivykdit)
            Assert.AreEqual(result, 37500);

        }
        [TestMethod]

        public void TaxShov1dBeSpercent0()
        {
            // Arange (paruost)

            //Act (patikrint)
            decimal result = Program.Tax(0);
            //Assert (ivykdit)
            Assert.AreEqual(result, 0);

        }
    }
}