using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class SibaraTests
    {
        [TestMethod]
        public void input_1_1_1_1_should_be_sameColor()
        {
            var target = new Sibara(1, 1, 1, 1);
            var expected = "same color";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_1_3_4_2_should_be_noPoints()
        {
            var target = new Sibara(1, 3, 4, 2);
            var expected = "no points";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_3_6_3_3_should_be_noPoints()
        {
            var target = new Sibara(3, 6, 3, 3);
            var expected = "no points";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void input_6_2_6_2_should_be_Sibala()
        {
            var target = new Sibara(6, 2, 6, 2);
            var expected = "sibala";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void input_5_5_2_2_should_be_10_Points()
        {
            var target = new Sibara(5, 5, 2, 2);
            var expected = "10 point";
            var actual = target.SibaraResult;
            Assert.AreEqual(expected, actual);
        }
    }
}
