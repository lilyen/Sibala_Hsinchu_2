using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class NormalPointsHandler
    {
        private Sibara _sibara;

        public NormalPointsHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetResult()
        {
            if (_sibara._nums.Distinct().Count() == 2)
            {
                _sibara.Points = _sibara._nums.Take(2).Sum();
                _sibara.MaxPoint = _sibara._nums.Max();
            }
            else
            {
                _sibara.Points = _sibara._nums.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
                _sibara.MaxPoint = _sibara._nums.GroupBy(x => x).Where(x => x.Count() == 1).Max(x => x.Key);
            }

            _sibara.Status = SibaraStatus.StatusEnum.Point;
            SetOutput();
        }

        private void SetOutput()
        {
            if (_sibara.Status == SibaraStatus.StatusEnum.SameColor)
                _sibara.Output = "same color";
            else if (_sibara.Status == SibaraStatus.StatusEnum.NoPoint)
                _sibara.Output = "no points";
            else if (_sibara.Status == SibaraStatus.StatusEnum.Point)
            {
                if (_sibara.Points == 12)
                    _sibara.Output = "sibala";
                else if (_sibara.Points == 3)
                {
                    _sibara.Output = "BG";
                }
                else
                    _sibara.Output = $"{_sibara.Points} point";
            }
        }
    }
}