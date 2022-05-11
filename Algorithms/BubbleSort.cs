namespace Algorithms
{
    public static partial class Tasks
    {
        public static int[] BubbleSort(int[] initArray)
        {
            var array = new int[initArray.Length];
            initArray.CopyTo(array, 0);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i == j)
                        continue;

                    if (array[i] < array[j])
                    {
                        SwapValue(j, i, array);
                    }
                }
            }

            return array;
        }

        public static void SwapValue(int oldIndex, int newIndex, int[] array)
        {
            var tmpValue = array[newIndex];
            array[newIndex] = array[oldIndex];
            array[oldIndex] = tmpValue;
        }

        public static int[] Reverse(int[] initArray)
        {
            var array = new int[initArray.Length];
            initArray.CopyTo(array, 0);

            var count = array.Length;
            var middleIndex = count / 2;
            for (int i = 0; i < middleIndex; i++)
            {
                var neighborIndex = count - i - 1;
                SwapValue(neighborIndex, i, array);
            }

            return array;
        }
    }
}
