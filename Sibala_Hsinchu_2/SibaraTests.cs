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
            VerifySibala(target, SibaraStatus.StatusEnum.SameColor, "same color", 1, 1);
        }

        [TestMethod]
        public void input_1_3_4_2_should_be_noPoints()
        {
            var target = new Sibara(1, 3, 4, 2);
            VerifySibala(target, SibaraStatus.StatusEnum.NoPoint, "no points", 0, 0);
        }

        [TestMethod]
        public void input_3_6_3_3_should_be_noPoints()
        {
            var target = new Sibara(3, 6, 3, 3);
            VerifySibala(target, SibaraStatus.StatusEnum.NoPoint, "no points", 0, 0);
        }

        [TestMethod]
        public void input_6_2_6_2_should_be_Sibala()
        {
            var target = new Sibara(6, 2, 6, 2);
            VerifySibala(target, SibaraStatus.StatusEnum.Point, "sibala", 12, 6);
        }

        [TestMethod]
        public void input_5_5_2_2_should_be_10_Points()
        {
            var target = new Sibara(5, 5, 2, 2);
            VerifySibala(target, SibaraStatus.StatusEnum.Point, "10 point", 10, 5);
        }

        [TestMethod]
        public void input_4_4_2_1_should_be_BG()
        {
            var target = new Sibara(4, 4, 2, 1);
            VerifySibala(target, SibaraStatus.StatusEnum.Point, "BG", 3, 2);
        }

        [TestMethod]
        public void input_5_5_4_3_should_be_7_Points()
        {
            var target = new Sibara(5, 5, 4, 3);
            VerifySibala(target, SibaraStatus.StatusEnum.Point, "7 point", 7, 4);
        }

        private void VerifySibala(Sibara target, SibaraStatus.StatusEnum status, string result, int points, int maxPoint)
        {
            Assert.AreEqual(status, target.Status);
            Assert.AreEqual(result, target.SibaraResult);
            Assert.AreEqual(points, target.Points);
            Assert.AreEqual(maxPoint, target.MaxPoint);
        }
    }
}