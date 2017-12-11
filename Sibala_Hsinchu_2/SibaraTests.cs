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
            StatusShouldBe(SibaraStatus.StatusEnum.SameColor);
            PointsShouldBe(2);
        }

        private void PointsShouldBe(int expected)
        {
            Assert.AreEqual(expected, _target.Points);
        }

        private void StatusShouldBe(SibaraStatus.StatusEnum expected)
        {
            Assert.AreEqual(expected, _target.Status);
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
        public void input_1_3_4_2()
        {
            _target = new Sibara(1, 3, 4, 2);
            OutputShouldBe("no points");
            MaxPointShouldBe(4);
            StatusShouldBe(SibaraStatus.StatusEnum.NoPoint);
            PointsShouldBe(0);
        }

        [TestMethod]
        public void input_3_6_3_3()
        {
            _target = new Sibara(3, 6, 3, 3);
            OutputShouldBe("no points");
            MaxPointShouldBe(6);
            StatusShouldBe(SibaraStatus.StatusEnum.NoPoint);
            PointsShouldBe(0);
        }

        [TestMethod]
        public void input_6_2_6_2()
        {
            _target = new Sibara(6, 2, 6, 2);
            OutputShouldBe("sibala");
            MaxPointShouldBe(6);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
            PointsShouldBe(12);
        }

        [TestMethod]
        public void input_5_5_2_2()
        {
            _target = new Sibara(5, 5, 2, 2);
            OutputShouldBe("10 point");
            MaxPointShouldBe(5);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
            PointsShouldBe(10);
        }

        [TestMethod]
        public void input_4_4_2_1()
        {
            _target = new Sibara(4, 4, 2, 1);
            OutputShouldBe("BG");
            MaxPointShouldBe(2);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
            PointsShouldBe(3);
        }

        [TestMethod]
        public void input_5_5_4_3()
        {
            _target = new Sibara(5, 5, 4, 3);
            OutputShouldBe("7 point");
            MaxPointShouldBe(4);
            StatusShouldBe(SibaraStatus.StatusEnum.Point);
            PointsShouldBe(7);
        }
    }
}