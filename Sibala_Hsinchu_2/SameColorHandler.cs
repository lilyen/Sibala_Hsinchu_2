using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class SameColorHandler
    {
        private Sibara _sibara;

        public SameColorHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetResult()
        {
            _sibara.Points = _sibara._nums.Sum() / 2;
            _sibara.Status = SibaraStatus.StatusEnum.SameColor;
            _sibara.MaxPoint = _sibara._nums.First();
            _sibara.Output = "same color";
        }
    }
}