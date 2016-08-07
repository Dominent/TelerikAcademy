namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong value;

        private const int length = 64;

        private int[] bitArray;

        public BitArray64(ulong setValue)
        {
            this.value = setValue;
            bitArray = ConvertToBits();
        }

        private int[] ConvertToBits()
        {
            var strBuilder = new StringBuilder();

            var intArray = new int[length];

            ulong mask = 1UL;

            for (int i = 0; i < length; i++)
            {
                intArray[i] = (int)((this.value & mask << i) >> i);
            }

            Array.Reverse(intArray);
            //var intArray = strBuilder.ToString().Select(x=>Convert.ToInt32(x)).ToArray();

            return intArray;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in bitArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int this[int index]
        {
            get { return this.bitArray[index]; }
            set { this.bitArray[index] = value; }
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return String.Join(string.Empty, this.bitArray);
        }

        public override int GetHashCode()
        {
            return bitArray.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BitArray64))
            {
                return false;
            }
            obj = obj as BitArray64;

            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }

            return false;
        }
    }
}
