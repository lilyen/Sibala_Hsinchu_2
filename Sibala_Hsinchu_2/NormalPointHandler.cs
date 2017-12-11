using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class NormalPointHandler : IDiceHandler
    {
        private Sibara _sibara;

        public NormalPointHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetResult()
        {
            var pointOfPairDices = _sibara._nums.GroupBy(x => x)
                .Where(x => x.Count() == 2).Min(x => x.Key);

            var pointsDices = _sibara._nums.Where(x => x != pointOfPairDices);

            _sibara.Points = pointsDices.Sum();
            _sibara.MaxPoint = pointsDices.Max();
            _sibara.Output = GetSpecialPoints();
            _sibara.Status = SibaraStatus.StatusEnum.Point;
        }

        private string GetSpecialPoints()
        {
            var specialOutput = new Dictionary<int, string>()
            {
                {12,"sibala" },
                {3,"BG" },
            };

            return specialOutput.ContainsKey(_sibara.Points) ? specialOutput[_sibara.Points] : $"{_sibara.Points} point";
        }
    }
}