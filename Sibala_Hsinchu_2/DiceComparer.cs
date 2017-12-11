using System.Collections.Generic;

namespace Sibala_Hsinchu_2
{
    internal class DiceComparer : IComparer<ISibara>
    {
        private Dictionary<int, int> sameColorCompareWeightLookup = new Dictionary<int, int>
        {
            {4,1 },
            {6,2 },
            {10,3 },
            {12,4 },
            {8,5 },
            {2,6 },
        };

        public int Compare(ISibara firstDice, ISibara secondDice)
        {
            if (firstDice.Status == secondDice.Status)
            {
                if (firstDice.Status == SibaraStatus.StatusEnum.NoPoint)
                {
                    return GetResultWhenNoPoint();
                }
                if (firstDice.Status == SibaraStatus.StatusEnum.SameColor)
                {
                    return GetResultWhenSameColor(firstDice, secondDice);
                }
                if (firstDice.Status == SibaraStatus.StatusEnum.Point)
                {
                    return GetResultWhenNormalPoints(firstDice, secondDice);
                }
            }

            return firstDice.Status - secondDice.Status;
        }

        private static int GetResultWhenNormalPoints(ISibara firstDice, ISibara secondDice)
        {
            if (firstDice.Points == secondDice.Points)
            {
                return firstDice.MaxPoint - secondDice.MaxPoint;
            }
            return firstDice.Points - secondDice.Points;
        }

        private int GetResultWhenSameColor(ISibara firstDice, ISibara secondDice)
        {
            return sameColorCompareWeightLookup[firstDice.Points] -
                   sameColorCompareWeightLookup[secondDice.Points];
        }

        private static int GetResultWhenNoPoint()
        {
            return 0;
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