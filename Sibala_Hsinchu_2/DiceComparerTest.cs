using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class DiceComparerTest
    {
        [TestMethod]
        public void noPoints_should_be_equal_to_noPoints()
        {
            var dice1 = new Sibara(6, 1, 3, 4);
            var dice2 = new Sibara(3, 4, 1, 2);

            FirstDiceShouldBeEqualToSecond(dice1, dice2);
        }

        private static void FirstDiceShouldBeEqualToSecond(ISibara dice1, ISibara dice2)
        {
            Assert.AreEqual(0, new DiceComparer().Compare(dice1, dice2));
        }

        [TestMethod]
        public void samecolor_4444_greater_than_2222()
        {
            var dice1 = new Sibara(4, 4, 4, 4);
            var dice2 = new Sibara(2, 2, 2, 2);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        private static void FirstDiceShouldGreaterThanSecond(ISibara dice1, ISibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void normalPoints_6146_should_less_than_4255()
        {
            var dice1 = new Sibara(6, 1, 4, 6);
            var dice2 = new Sibara(4, 2, 5, 5);

            FirstDiceShouldBeLesserThanSecond(dice1, dice2);
        }

        private static void FirstDiceShouldBeLesserThanSecond(ISibara dice1, ISibara dice2)
        {
            new DiceComparer().Compare(dice1, dice2).Should().BeLessThan(0);
        }

        [TestMethod]
        public void samecolor_1111_should_greater_than_2222()
        {
            var dice1 = new Sibara(1, 1, 1, 1);
            var dice2 = new Sibara(2, 2, 2, 2);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void samecolor_1111_should_greater_than_4444()
        {
            var dice1 = new Sibara(1, 1, 1, 1);
            var dice2 = new Sibara(4, 4, 4, 4);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoints_1421_should_greater_than_1313()
        {
            var dice1 = new Sibara(1, 4, 2, 1);
            var dice2 = new Sibara(1, 3, 1, 3);
            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void samecolor_should_greater_than_normalPoints()
        {
            var dice1 = new Sibara(1, 1, 1, 1);
            var dice2 = new Sibara(1, 3, 3, 4);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoints_should_be_lesser_than_sameColor()
        {
            var dice1 = new Sibara(3, 1, 3, 4);
            var dice2 = new Sibara(1, 1, 1, 1);

            FirstDiceShouldBeLesserThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void sameColor_should_be_greater_than_noPoint()
        {
            var dice1 = new Sibara(1, 1, 1, 1);
            var dice2 = new Sibara(3, 1, 2, 6);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoints_should_be_greater_than_noPoint()
        {
            var dice1 = new Sibara(3, 1, 3, 4);
            var dice2 = new Sibara(5, 1, 3, 2);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoints_4154_should_greater_than_3134()
        {
            var dice1 = new Sibara(4, 1, 5, 4);
            var dice2 = new Sibara(3, 1, 3, 4);

            FirstDiceShouldGreaterThanSecond(dice1, dice2);
        }

        [TestMethod]
        public void normalPoints_2343_should_be_equal_to_4525_with_same_maxPoint()
        {
            var dice1 = new Sibara(2, 3, 4, 3);
            var dice2 = new Sibara(4, 5, 2, 5);

            FirstDiceShouldBeEqualToSecond(dice1, dice2);
        }
    }
}