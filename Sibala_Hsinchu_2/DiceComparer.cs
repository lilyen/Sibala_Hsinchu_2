using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala_Hsinchu_2
{
    class DiceComparer : IComparer<ISibara>
    {
        public int Compare(ISibara firstDice, ISibara secondDice)
        {
            return firstDice.Status - secondDice.Status;
        }
    }
}
