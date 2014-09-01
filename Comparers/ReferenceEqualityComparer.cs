using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace mijay.Utils.Comparers
{
    public class ReferenceEqualityComparer: IEqualityComparer<object>
    {
        public static readonly IEqualityComparer<object> Instance = new ReferenceEqualityComparer();

        private ReferenceEqualityComparer()
        {
        }

        public new bool Equals(object x, object y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(object obj)
        {
            return RuntimeHelpers.GetHashCode(obj);
        }
    }
}