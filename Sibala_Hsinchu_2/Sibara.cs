using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class Sibara : ISibara
    {
        private List<int> _nums;

        public Sibara(int n1, int n2, int n3, int n4)
        {
            _nums = new List<int> { n1, n2, n3, n4 }.OrderByDescending(x => x).ToList();
            Compute();
        }

        public int Points { get; protected set; }
        public int MaxPoint { get; protected set; }

        public SibaraStatus.StatusEnum Status { get; protected set; }

        public string Output { get; protected set; }

        protected virtual void Compute()
        {
            if (IsSameColor())
            {
                SetSameColor();
                return;
            }

            if (IsNoPoint())
            {
                SetNoPoint();
                return;
            }

            SetNormalPoints();
        }

        private void SetSameColor()
        {
            this.Points = _nums.Sum() / 2;
            this.Status = SibaraStatus.StatusEnum.SameColor;
            this.MaxPoint = _nums.First();
            this.Output = "same color";
        }

        private void SetNoPoint()
        {
            Points = 0;
            Status = SibaraStatus.StatusEnum.NoPoint;
            this.MaxPoint = _nums.First();
            Output = "no points";
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

        private bool IsNoPoint()
        {
            var isSamePointWith3Dices = _nums.GroupBy(item => item).Select(item => item.Count()).Max() == 3;
            return _nums.Distinct().Count() == 4 || isSamePointWith3Dices;
        }

        private bool IsSameColor()
        {
            return _nums.Distinct().Count() == 1;
        }

        private void SetSibaraResult()
        {
            if (Status == SibaraStatus.StatusEnum.SameColor)
                this.Output = "same color";
            else if (Status == SibaraStatus.StatusEnum.NoPoint)
                this.Output = "no points";
            else if (Status == SibaraStatus.StatusEnum.Point)
            {
                SetSpecialPoints();
            }
        }

        private void SetSpecialPoints()
        {
            if (Points == 12)
                this.Output = "sibala";
            else if (Points == 3)
            {
                this.Output = "BG";
            }
            else
                this.Output = $"{Points} point";
        }
    }
}