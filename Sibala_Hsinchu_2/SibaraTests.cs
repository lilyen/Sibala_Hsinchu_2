using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class SibaraTests
    {
        private Sibara _target;

        [TestMethod]
        public void input_1_1_1_1_should_be_sameColor()
        {
            _target = new Sibara(1, 1, 1, 1);
            OutputShouldBe("same color");
            MaxPointShouldBe(1);
            PointsShouldBe(2);
            StatusShouldBe(SibaraStatus.StatusEnum.SameColor);
        }

        private void StatusShouldBe(SibaraStatus.StatusEnum expected)
        {
            Assert.AreEqual(expected, _target.Status);
        }

        private void PointsShouldBe(int expected)
        {
            Assert.AreEqual(expected, _target.Points);
        }

        private void MaxPointShouldBe(int expected)
        {
            Assert.AreEqual(expected, _target.MaxPoint);
        }

        private void OutputShouldBe(string expected)
        {
            Assert.AreEqual(expected, _target.Output);
        }

        [TestMethod]
        public void input_1_3_4_2_should_be_noPoints()
        {
            _target = new Sibara(1, 3, 4, 2);
            OutputShouldBe("no points");
            MaxPointShouldBe(4);
            PointsShouldBe(0);
            StatusShouldBe(SibaraStatus.StatusEnum.NoPoint);
        }

        [TestMethod]
        public void input_3_6_3_3_should_be_noPoints()
        {
            _target = new Sibara(3, 6, 3, 3);
            OutputShouldBe("no points");
            MaxPointShouldBe(6);
            PointsShouldBe(0);
            StatusShouldBe(SibaraStatus.StatusEnum.NoPoint);
        }

        [TestMethod]
        public void input_6_2_6_2_should_be_Sibala()
        {
            _target = new Sibara(6, 2, 6, 2);
            OutputShouldBe("sibala");
            MaxPointShouldBe(6);
            PointsShouldBe(12);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
        }

        [TestMethod]
        public void input_5_5_2_2_should_be_10_Points()
        {
            _target = new Sibara(5, 5, 2, 2);
            OutputShouldBe("10 point");
            MaxPointShouldBe(5);
            PointsShouldBe(10);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
        }

        [TestMethod]
        public void input_4_4_2_1_should_be_BG()
        {
            _target = new Sibara(4, 4, 2, 1);
            OutputShouldBe("BG");
            MaxPointShouldBe(2);
            PointsShouldBe(3);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
        }

        [TestMethod]
        public void input_5_5_4_3_should_be_7_Points()
        {
            _target = new Sibara(5, 5, 4, 3);
            OutputShouldBe("7 point");
            MaxPointShouldBe(4);
            PointsShouldBe(7);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
        }
    }
}