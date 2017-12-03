using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class DiceComparerTest
    {
        [TestMethod]
        public void DiceComparer_NoPoint_6_1_3_4_Compare_NoPoint_3_4_1_2_Should_be_0()
        {
            //arrange
            var noPoint1 = new Sibara(6, 1, 3, 4);
            var noPoint2 = new Sibara(3, 4, 1, 2);
            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(noPoint1, noPoint2);
            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}