using System;
using System.Buffers;

namespace Demo.NetAnalysers.NetCore31
{
    class DerivedClass<T> : MemoryManager<T>
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public override Span<T> GetSpan()
        {
            return default;
        }

        public override MemoryHandle Pin(int elementIndex = 0)
        {
            return default;
        }

        public override void Unpin()
        {
        }

        // Violation occurs, remove the finalizer to fix the warning.
        ~DerivedClass() => Dispose(false);
    }
}
