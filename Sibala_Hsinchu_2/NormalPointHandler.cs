using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class NormalPointHandler
    {
        private Sibara _sibara;

        public NormalPointHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetNormalPoints()
        {
            if (_sibara._nums.Distinct().Count() == 2)
            {
                _sibara.Points = _sibara._nums.Take(2).Sum();
                _sibara.MaxPoint = _sibara._nums.Max();
                _sibara.Output = _sibara.Points + " point";
                SetSpecialPoints();
                _sibara.Status = SibaraStatus.StatusEnum.Point;
            }
            else
            {
                _sibara.Points = _sibara._nums.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
                _sibara.MaxPoint = _sibara._nums.GroupBy(x => x).Where(x => x.Count() == 1).Max(x => x.Key);
                _sibara.Output = _sibara.Points + " point";
                SetSpecialPoints();
                _sibara.Status = SibaraStatus.StatusEnum.Point;
            }
        }

        private void SetSpecialPoints()
        {
            var specialOutput = new Dictionary<int, string>()
            {
                {12,"sibala" },
                {3,"BG" },
            };

            _sibara.Output = specialOutput.ContainsKey(_sibara.Points) ? specialOutput[_sibara.Points] : $"{_sibara.Points} point";
        }
    }
}