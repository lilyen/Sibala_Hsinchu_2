using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class DiceComparerTest
    {
        [TestMethod]
        public void DiceComparer_NoPoint_6_1_3_4_Compare_NoPoint_3_4_1_2_Should_be_0()
        {
            var noPoint1 = Substitute.For<ISibara>();
            noPoint1.Status.Returns(SibaraStatus.StatusEnum.NoPoint);

            var noPoint2 = Substitute.For<ISibara>();
            noPoint2.Status.Returns(SibaraStatus.StatusEnum.NoPoint);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(noPoint1, noPoint2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiceComparer_SameColor_4_4_4_4_Compare_SameColor_2_2_2_2_Should_grater_0()
        {
            var nPoint1 = Substitute.For<ISibara>();
            nPoint1.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            nPoint1.Points.Returns(8);

            var noPoint2 = Substitute.For<ISibara>();
            noPoint2.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            noPoint2.Points.Returns(4);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(nPoint1, noPoint2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }
    }
}