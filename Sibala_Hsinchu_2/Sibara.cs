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
            new NormalPointHandler(this).SetNormalPoints();
        }

    }
}