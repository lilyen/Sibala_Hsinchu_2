using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala_Hsinchu_2
{
    class DiceComparer : IComparer<ISibara>
    {
        private Dictionary<int, int> dict;

        public DiceComparer()
        {
            dict = new Dictionary<int, int>()
            {
                [0] = 4,
                [1] = 6,
                [2] = 10,
                [3] = 12,
                [4] = 8,
                [5] = 2,

            };
        }
        
        public int Compare(ISibara firstDice, ISibara secondDice)
        {

            if (IsBothDiceSameColor(firstDice, secondDice))
            {
                return
                    dict.First(x => x.Value == firstDice.Points).Key -
                    dict.First(x => x.Value == secondDice.Points).Key;
            }

            if (IsBothDiceSameStatus(firstDice, secondDice))
            {
                if (firstDice.Points == secondDice.Points)
                {
                    return firstDice.MaxPoint - secondDice.MaxPoint;
                }
                return firstDice.Points - secondDice.Points;
            }



            
            return firstDice.Status - secondDice.Status;
        }

        private static bool IsBothDiceSameStatus(ISibara firstDice, ISibara secondDice)
        {
            return firstDice.Status == secondDice.Status;
        }

        private bool IsBothDiceSameColor(ISibara firstDice, ISibara secondDice)
        {
            return firstDice.Status == SibaraStatus.StatusEnum.SameColor &&
                   secondDice.Status == SibaraStatus.StatusEnum.SameColor;
        }
    }
}
