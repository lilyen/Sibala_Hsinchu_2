using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

namespace Sibala_Hsinchu_2
{
    public class Sibara : ISibara
    {
        private List<int> _nums;

        public Sibara(int n1, int n2, int n3, int n4)
        {
            _nums = new List<int> {n1, n2, n3, n4}.OrderByDescending(x=>x).ToList();
            Compute();
        }

        public int Points { get; protected set; }
        public int MaxPoint { get; }

        public SibaraStatus.StatusEnum Status { get; protected set; }

        public string SibaraResult { get; protected set; }

        protected  virtual void Compute()
        {
            var distinctCount = _nums.Distinct().Count();

            if (distinctCount == 1)
            {
                this.Points = _nums.Sum()/2;
                this.Status = SibaraStatus.StatusEnum.SameColor;
            }else if (distinctCount == 4)
            {
                Points = 0;
                Status = SibaraStatus.StatusEnum.NoPoint;
            }
            else if (distinctCount == 2)
            {
                var count = _nums.GroupBy(item => item).Select(item => item.Count()).Max();
                if (count == 3)
                {
                    Points = 0;
                    Status = SibaraStatus.StatusEnum.NoPoint;
                }
                else
                {
                    Points = _nums.Take(2).Sum();
                    Status = SibaraStatus.StatusEnum.Point;
                }
            }

            SetSibaraResult();
        }

        private void SetSibaraResult()
        {
            if (Status == SibaraStatus.StatusEnum.SameColor)
                this.SibaraResult = "same color";
            else if (Status == SibaraStatus.StatusEnum.NoPoint)
                this.SibaraResult = "no points";
            else if (Status == SibaraStatus.StatusEnum.Point)
            {
                if (Points == 12)
                    this.SibaraResult = "sibala";
                else
                this.SibaraResult = $"{Points} point";
            }
        }

    }
}