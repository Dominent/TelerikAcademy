namespace RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException where T : struct
    {
        private readonly T start;

        private readonly T end;

        public InvalidRangeException(T setStart, T setEnd, string message) : base(message)
        {
            this.start = setStart;
            this.end = setEnd;
        }

        T Start { get { return this.start; } }

        T End { get { return this.end; } }
    }
}
