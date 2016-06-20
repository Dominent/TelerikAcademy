namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGenericList<T> : IEnumerable<T>
    {
        void Add(T item);

        void Remove(T item);

        void RemoveAt(int index);

        void InsertAt(T item, int index);

        void Clear();

        int FindByValue(T value);
    }
}
