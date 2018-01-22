using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Sibala_Hsinchu_2
{
    [TestClass]
    public class SibaraTests
    {
        [TestCase(1, 1, 1, 1, SibaraStatus.StatusEnum.SameColor, "same color", 1, 1, TestName = "input_1_1_1_1_should_be_sameColor")]
        [TestCase(1, 3, 4, 2, SibaraStatus.StatusEnum.NoPoint, "no points", 0, 0, TestName = "input_1_3_4_2_should_be_noPoints")]
        [TestCase(3, 6, 3, 3, SibaraStatus.StatusEnum.NoPoint, "no points", 0, 0, TestName = "input_3_6_3_3_should_be_noPoints")]
        [TestCase(6, 2, 6, 2, SibaraStatus.StatusEnum.Point, "sibala", 12, 6, TestName = "input_6_2_6_2_should_be_Sibala")]
        [TestCase(5, 5, 2, 2, SibaraStatus.StatusEnum.Point, "10 point", 10, 5, TestName = "input_5_5_2_2_should_be_10_Points")]
        [TestCase(4, 4, 2, 1, SibaraStatus.StatusEnum.Point, "BG", 3, 2, TestName = "input_4_4_2_1_should_be_BG")]
        [TestCase(5, 5, 4, 3, SibaraStatus.StatusEnum.Point, "7 point", 7, 4, TestName = "input_5_5_4_3_should_be_7_Points")]
        public void Test_Silbala(int dice1, int dice2, int dice3, int dice4, SibaraStatus.StatusEnum status, string result, int points, int maxPoint)
        {
            var target = new Sibara(dice1, dice2, dice3, dice4);
            VerifySibala(target, status, result, points, maxPoint);
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