using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    public static partial class Tasks
    {
        public static Task<Task<T>> MyWhenAny<T>(params Task<T>[] tasks)
        {
            //return Task.WhenAny(tasks);
            var isCompleted = 1;

            var tcs = new TaskCompletionSource<Task<T>>();
            foreach (var task in tasks)
            {
                task.ContinueWith(_ =>
                {
                    if (Interlocked.Exchange(ref isCompleted, 0) == 1)
                    {
                        tcs.TrySetResult(task);
                    }
                });
            }

            return tcs.Task;
        }
    }
}