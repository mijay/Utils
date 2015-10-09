using System;
using System.Threading.Tasks;

namespace mijay.Utils.Tasks
{
#if NET40
    public static class TaskExtensions
    {
        public static Task Then<T>(this Task<T> task, Action<T> action)
        {
            Guard.AgainstNull(task, "task");
            Guard.AgainstNull(action, "action");

            return task.ContinueWith(t => action(t.Result),
                TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.OnlyOnRanToCompletion);
        }
    }
#endif
}
