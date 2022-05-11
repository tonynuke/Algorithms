using System;
using System.Linq;

namespace Algorithms
{
    public static partial class Tasks
    {
        public static int[] SquareAndSort(int[] initArray)
        {
            if (initArray[0] >= 0)
                return initArray.Select(x => x * x).ToArray();

            var array = new int[initArray.Length];

            var negativeOrZeroNumberIndex = 0;
            var positiveNumberIndex = array.Length - 1;
            var insertIndex = array.Length - 1;

            while (insertIndex >= 0)
            {
                var negativeOrZeroNumber = initArray[negativeOrZeroNumberIndex];
                var positiveNumber = initArray[positiveNumberIndex];

                if (Math.Abs(negativeOrZeroNumber) > positiveNumber)
                {
                    array[insertIndex] = negativeOrZeroNumber * negativeOrZeroNumber;
                    negativeOrZeroNumberIndex++;
                }
                else
                {
                    array[insertIndex] = positiveNumber * positiveNumber;
                    positiveNumberIndex--;
                }
                insertIndex--;
            }

            return array;
        }
    }
}