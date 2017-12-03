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
    }
}
