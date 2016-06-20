namespace Structure
{
    using System.Collections.Generic;
    using System.Text;
    using System.Collections;

    public class Path : IEnumerable
    {
        public Path()
        {
            this.Sequence = new List<Point3D>();
        }

        public List<Point3D> Sequence { get; }

        public void AddPoint(Point3D point) => this.Sequence.Add(point);

        public void RemovePoint(Point3D point) => this.Sequence.Remove(point);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Sequence.GetEnumerator();
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            foreach (var point in Sequence)
                strBuilder.AppendLine(point.ToString());

            return strBuilder.ToString();
        }
    }
}
