using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class DiceComparerTest
    {
        [TestMethod]
        public void NoPoint_is_equal_to_noPoint()
        {
            var dice1 = new Sibara(6, 1, 3, 4);
            var dice2 = new Sibara(3, 4, 1, 2);

            FirstDiceIsEqualToSecond(dice1, dice2);
        }

        private static void FirstDiceIsEqualToSecond(Sibara dice1, Sibara dice2)
        {
            Assert.AreEqual(0, new DiceComparer().Compare(dice1, dice2));
        }

        [TestMethod]
        public void DiceComparer_SameColor_4_4_4_4_Compare_SameColor_2_2_2_2_Should_grater_0()
        {
            var dice1 = new Sibara(4, 4, 4, 4);
            var dice2 = new Sibara(2, 2, 2, 2);
            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        private static void FirstDiceShouldBeGreaterThanSecond(Sibara dice1, Sibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void DiceComparer_NPoint_6_1_4_6_Compare_NPoint_4_2_5_5_Should_Less_0()
        {
            var dice1 = new Sibara(6, 1, 4, 6);
            var dice2 = new Sibara(4, 2, 5, 5);

            FirstDiceShouldBeLessThanSecond(dice1, dice2);
        }

        private static void FirstDiceShouldBeLessThanSecond(Sibara dice1, Sibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().BeLessThan(0);
        }

        [TestMethod]
        public void SameColor_1111_greater_than_2222()
        {
            var dice1 = new Sibara(1, 1, 1, 1);

            var dice2 = new Sibara(2, 2, 2, 2);

            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void SameColor_1111_greater_than_4444()
        {
            var dice1 = new Sibara(1, 1, 1, 1);

            var dice2 = new Sibara(4, 4, 4, 4);

            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoint_1421_great_than_1313()
        {
            var dice1 = new Sibara(1, 4, 2, 1);

            var dice2 = new Sibara(1, 3, 1, 3);

            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void sameColor_greater_than_normalPoint()
        {
            var dice1 = new Sibara(1, 1, 1, 1);

            var dice2 = new Sibara(1, 3, 3, 4);
            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void DiceComparer_NPoint_3_1_3_4_Compare_SameColor_1_1_1_1_Should_Less_0()
        {
            var dice1 = new Sibara(3, 1, 3, 4);

            var dice2 = new Sibara(1, 1, 1, 1);

            FirstDiceShouldBeLessThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void sameColor_great_than_no_point()
        {
            var dice1 = new Sibara(1, 1, 1, 1);

            var dice2 = new Sibara(3, 1, 2, 6);

            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoint_great_than_noPoint()
        {
            var dice1 = new Sibara(3, 1, 3, 4);

            var dice2 = new Sibara(5, 1, 3, 2);
            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoint_4154_great_than_3134()
        {
            var dice1 = new Sibara(4, 1, 5, 4);

            var dice2 = new Sibara(3, 1, 3, 4);
            FirstDiceShouldBeGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void NormalPoint_2343_equal_to_4525_with_same_maxPoint()
        {
            var dice1 = new Sibara(2, 3, 4, 3);

            var dice2 = new Sibara(4, 5, 2, 5);

            FirstDiceIsEqualToSecond(dice1, dice2);
        }
    }
}