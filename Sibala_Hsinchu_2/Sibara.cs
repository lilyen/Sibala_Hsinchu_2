using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class Sibara : ISibara
    {
        public List<int> _nums;

        public Sibara(int n1, int n2, int n3, int n4)
        {
            _nums = new List<int> { n1, n2, n3, n4 }.OrderByDescending(x => x).ToList();
            Compute();
        }

        public int Points { get; set; }
        public int MaxPoint { get; set; }

        public SibaraStatus.StatusEnum Status { get; set; }

        public string Output { get; set; }

        protected virtual void Compute()
        {
            var maxCountOfSamePoint = _nums.GroupBy(x => x).Max(x => x.Count());

            if (maxCountOfSamePoint == 4)
            {
                new SameColorHandler(this).SetSameColor();
                return;
            }

            if (maxCountOfSamePoint == 1 || maxCountOfSamePoint == 3)
            {
                new NoPointHandler(this).SetNoPoint();
                return;
            }
            SetNormalPoints();
        }

        private void SetNormalPoints()
        {
            if (_nums.Distinct().Count() == 2)
            {
                Points = _nums.Take(2).Sum();
                this.MaxPoint = _nums.Max();
                Output = Points + " point";
                SetSpecialPoints();
                Status = SibaraStatus.StatusEnum.Point;
            }
            else
            {
                Points = _nums.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
                this.MaxPoint = _nums.GroupBy(x => x).Where(x => x.Count() == 1).Max(x => x.Key);
                Output = Points + " point";
                SetSpecialPoints();
                Status = SibaraStatus.StatusEnum.Point;
            }
        }

        private void SetSpecialPoints()
        {
            var specialOutput = new Dictionary<int, string>()
            {
                {12,"sibala" },
                {3,"BG" },
            };

            this.Output = specialOutput.ContainsKey(Points) ? specialOutput[Points] : $"{Points} point";
        }
    }
}