namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Collections;
    using System.Linq.Expressions;


    public class Matrix<T> : IEnumerable where T : struct,
        IComparable,
        IComparable<T>,
        IConvertible,
        IEquatable<T>,
        IFormattable
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public T[,] Elements;
        private int Index = 0;

        public Matrix(int row, int col)
        {
            Row = row;
            Col = col;
            Elements = new T[row, col];
        }

        public T this[int x, int y]
        {
            get { return Elements[x, y]; }
            set { this.Elements[x, y] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            try
            {
                Matrix<T> result = new Matrix<T>(a.Row, a.Col);

                for (int i = 0; i < result.Row; i++)
                    for (int j = 0; j < result.Col; j++)
                        result[i, j] = (dynamic)a.Elements[i, j] + b.Elements[i, j];

                return result;
            }
            catch (Exception)
            {
                throw new Exception("Oooops something went wrong");
            }
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            try
            {
                Matrix<T> result = new Matrix<T>(a.Row, a.Col);

                for (int i = 0; i < result.Row; i++)
                    for (int j = 0; j < result.Col; j++)
                        result[i, j] = (dynamic)a.Elements[i, j] - b.Elements[i, j];

                return result;
            }
            catch (Exception)
            {
                throw new Exception("Oooops something went wrong");
            }
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            try
            {
                Matrix<T> result = new Matrix<T>(a.Row, b.Col);

                for (int i = 0; i < result.Row; i++)
                {
                    for (int j = 0; j < result.Col; j++)
                    {
                        result[i, j] = (dynamic)0;
                        for (int k = 0; k < a.Col; k++)
                            result[i, j] += (dynamic)a.Elements[i, k] * b.Elements[k, j];
                    }
                }
                return result;
            }
            catch (Exception)
            {
                throw new Exception("Oooops something went wrong");
            }

        }

        public static bool operator true(Matrix<T> a)
        {
            for (int i = 0; i < a.Row; i++)
                for (int j = 0; j < a.Col; j++)
                    if (a.Elements[i, j] == (dynamic)0)
                        return true;

            return false;

        }

        public static bool operator false(Matrix<T> a)
        {
            for (int i = 0; i < a.Row; i++)
                for (int j = 0; j < a.Col; j++)
                    if (a.Elements[i, j] == (dynamic)0)
                        return false;

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        public override string ToString() 
        {
            var strBuilder = new StringBuilder();

            for (int i = 0; i < this.Row; i++)
            {
                strBuilder.Append("[ ");
                for (int j = 0; j < this.Col; j++)
                {
                    strBuilder.Append(Elements[i, j] + " ");
                }
                strBuilder.Append("]");
                strBuilder.AppendLine();
            }

            return strBuilder.ToString();
        }
    }
}
