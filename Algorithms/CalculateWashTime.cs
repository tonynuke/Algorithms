using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Tasks
    {
        public static int CalculateWashTime(
            int washMachinesCount, IEnumerable<int> washTimeQueue)
        {
            var resultTime = 0;
            var washIterationState = new int[washMachinesCount];

            using var enumerator = washTimeQueue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var washTime = enumerator.Current;
                for (var i = 0; i < washMachinesCount; i++)
                {
                    if (washIterationState[i] != 0)
                        continue;

                    washIterationState[i] = washTime;
                    break;
                }

                var washIterationTime = washIterationState.Min();
                resultTime += washIterationTime;
                for (var i = 0; i < washMachinesCount; i++)
                {
                    washIterationState[i] -= washIterationTime;
                }
            }

            var lastIterationTime = washIterationState.Max();
            return resultTime + lastIterationTime;
        }
    }
}