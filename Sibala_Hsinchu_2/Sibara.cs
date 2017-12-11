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
            if (IsSameColor())
            {
                new SameColorHandler(this).SetResult();
                return;
            }

            if (IsNoPoint())
            {
                new NoPointHandler(this).SetResult();
                return;
            }

            new NormalPointsHandler(this).SetResult();
        }

        private bool IsNoPoint()
        {
            var count = _nums.GroupBy(item => item).Select(item => item.Count()).Max();

            return _nums.Distinct().Count() == 4 || count == 3;
        }

        private bool IsSameColor()
        {
            return _nums.Distinct().Count() == 1;
        }


    }
}