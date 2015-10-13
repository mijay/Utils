using System.Threading.Tasks;

namespace mijay.Utils.Tasks
{
#if NET40
    public static class TaskEx
    {
        public static Task<T> FromResult<T>(T value)
        {
#if !NET45
            var result = new TaskCompletionSource<T>();
            result.SetResult(value);
            return result.Task;
#else
            return Task.FromResult(value);
#endif
        }
    }
#endif
}
