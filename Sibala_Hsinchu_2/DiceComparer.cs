using System;
using System.Collections.Generic;

namespace Sibala_Hsinchu_2
{
    internal class DiceComparer : IComparer<ISibara>
    {
        private Dictionary<int, int> sameColorComparerWeight = new Dictionary<int, int>
        {
            {4,1},
            {6,2},
            {10,3},
            {12,4},
            {8,5},
            {2,6},
        };

        public int Compare(ISibara firstDice, ISibara secondDice)
        {
            if (IsSameStatus(firstDice, secondDice))
            {
                var comparerLookup = new Dictionary<SibaraStatus.StatusEnum, Func<ISibara, ISibara, int>>()
                {
                    { SibaraStatus.StatusEnum.NoPoint, GetResultWhenNoPoint},
                    { SibaraStatus.StatusEnum.SameColor, GetResultWhenSameColor},
                    { SibaraStatus.StatusEnum.Point, GetResultWhenNormalPoint},
                };

                return comparerLookup[firstDice.Status].Invoke(firstDice, secondDice);
            }

            return firstDice.Status - secondDice.Status;
        }

        private int GetResultWhenNormalPoint(ISibara firstDice, ISibara secondDice)
        {
            if (firstDice.Points == secondDice.Points)
            {
                return firstDice.MaxPoint - secondDice.MaxPoint;
            }
            return firstDice.Points - secondDice.Points;
        }

        private int GetResultWhenSameColor(ISibara firstDice, ISibara secondDice)
        {
            return sameColorComparerWeight[firstDice.Points] - sameColorComparerWeight[secondDice.Points];
        }

        private int GetResultWhenNoPoint(ISibara x, ISibara y)
        {
            return 0;
        }

        private static bool IsSameStatus(ISibara firstDice, ISibara secondDice)
        {
            return firstDice.Status == secondDice.Status;
        }
    }
}