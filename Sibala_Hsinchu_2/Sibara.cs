using System;
using System.Collections.Generic;
using System.Linq;

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

        public int Points { get; private set; }

        public SibaraStatus.StatusEnum Status { get; private set; }

        public string SibaraResult { get; private set; }

        private void Compute()
        {
            throw new NotImplementedException();
        }
    }
}