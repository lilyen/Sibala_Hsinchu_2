using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class DiceComparerTest
    {
        [TestMethod]
        public void DiceComparer_NoPoint_Compare_NoPoint_Should_be_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.NoPoint);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.NoPoint);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiceComparer_SameColor_4_4_4_4_Compare_SameColor_2_2_2_2_Should_grater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara1.Points.Returns(8);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara2.Points.Returns(4);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_NPoint_6_1_4_6_Compare_NPoint_4_2_5_5_Should_Less_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara1.Points.Returns(5);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara2.Points.Returns(6);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeLessThan(expected);
        }

        [TestMethod]
        public void DiceComparer_SameColor_1_1_1_1_Compare_SameColor_2_2_2_2_Should_Less_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara1.Points.Returns(2);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara2.Points.Returns(4);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_SameColor_1_1_1_1_Compare_SameColor_4_4_4_4_Should_Greater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara1.Points.Returns(2);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara2.Points.Returns(8);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_SameColor_1_4_2_1_Compare_SameColor_1_3_1_3_Should_Greater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara1.Points.Returns(6);
            silbara1.MaxPoint.Returns(4);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara2.Points.Returns(6);
            silbara2.MaxPoint.Returns(3);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_SameColor_1_1_1_1_Compare_NPoint_1_3_3_4_Should_Greater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara1.Points.Returns(2);
            silbara1.MaxPoint.Returns(1);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara2.Points.Returns(5);
            silbara2.MaxPoint.Returns(4);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_NPoint_3_1_3_4_Compare_SameColor_1_1_1_1_Should_Less_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara1.Points.Returns(5);
            silbara1.MaxPoint.Returns(4);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.SameColor);
            silbara2.Points.Returns(2);
            silbara2.MaxPoint.Returns(1);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeLessThan(expected);
        }

        [TestMethod]
        public void DiceComparer_SameColor_1_1_1_1_Compare_NoPoint_3_1_2_6_Should_Greater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.SameColor);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.NoPoint);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_NPoint_3_1_3_4_Compare_NoPoint_5_1_3_2_Should_Greater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.Point);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.NoPoint);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_NPoint_4_1_5_4_Compare_NPoint_3_1_3_4_Should_Greater_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara1.Points.Returns(6);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.Point);
            silbara2.Points.Returns(5);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().BeGreaterThan(expected);
        }

        [TestMethod]
        public void DiceComparer_No_Point_2_3_4_3_Compare_No_Point_4_5_2_5_Should_0()
        {
            var silbara1 = Substitute.For<ISibara>();
            silbara1.Status.Returns(SibaraStatus.StatusEnum.NoPoint);
            silbara1.Points.Returns(6);
            silbara1.MaxPoint.Returns(4);

            var silbara2 = Substitute.For<ISibara>();
            silbara2.Status.Returns(SibaraStatus.StatusEnum.NoPoint);
            silbara2.Points.Returns(6);
            silbara2.MaxPoint.Returns(4);

            var diceComparer = new DiceComparer();
            var expected = 0;
            //act
            var actual = diceComparer.Compare(silbara1, silbara2);
            //assert
            actual.Should().Be(expected);
        }
    }
}