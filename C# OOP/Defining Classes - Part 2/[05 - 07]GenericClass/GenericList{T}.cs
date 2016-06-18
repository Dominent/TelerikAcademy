namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Collections;

    public class GenericList<T> : IEnumerable where T : IGenericList<T>, IComparable<T>
    {
        private int Size = 0;
        private T[] Elements;
        private int Index = 0;

        public GenericList(int size)
        {
            this.Size = size;
            Elements = new T[size];
        }

        public T this[int number]
        {
            get { return Elements[number]; }
            set { this.Elements[number] = value; }
        }

        // ToDo : Needs Testing
        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // ToDo : Works
        public void RemoveAt(int index)
        {
            T[] temp = new T[Elements.Length - 1];

            Array.Copy(Elements, 0, temp, 0, index);
            Array.Copy(Elements, index + 1, temp, index, ((Elements.Length - 2) - index));

            Elements = new T[temp.Length];

            Array.Copy(temp, Elements, temp.Length);

            --Index;
        }

        // ToDo : Add InsertAt index which is out of the array !
        public void InsertAt(T item, int index)
        {
            if (index > 0 && index < Elements.Length)
            {
                //Save the item in the array at index
                T[] temp = new T[Elements.Length - index];
                Array.Copy(Elements, index, temp, 0, (Elements.Length - index));

                //Set the new item
                Elements[index] = item;

                //Clear all elements after the item at index
                Array.Clear(Elements, index + 1, (Elements.Length - 1) - index);

                //Check if the array can hold the temp array
                if ((Elements.Length - 1) - index <= temp.Length)
                    Resize();

                //Join Arrays
                Array.Copy(temp, 0, Elements, index + 1, temp.Length);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Clear() => Array.Clear(Elements, 0, Elements.Length);

        public int FindByValue(T value) => Array.FindIndex(Elements, x => x.Equals(value));

        public void Add(T input)
        {
            if (Index > Elements.Length)
                Resize();

            Elements[Index] = input;
            ++Index;
        }

        public void Remove(T input) => Elements[FindByValue(input)] = default(T);

        private void Resize() => Array.Resize(ref Elements, Size * 2);

        public T Min() => Elements.Min();
        public T Max() => Elements.Max();

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append("[ ");
            foreach (var item in Elements)
                strBuilder.Append(item + " ");
            strBuilder.Append("]");

            return strBuilder.ToString();
        }
    }
}
