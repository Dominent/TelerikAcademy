namespace Structure
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    static class PathStorage
    {
        private static readonly string FileName = "Paths";

        public static Path LoadPaths()
        {
            var pattern = @"[-+]?[0-9,\.]*([,\.])[0-9]+";
            var rgx = new Regex(pattern);

            var strBuilder = new StringBuilder();
            var path = new Path();

            using (StreamReader strReader = new StreamReader(FileName))
            {
                strBuilder.Append(strReader.ReadToEnd());
            }

            foreach (var matches in strBuilder.ToString().Split('*').Select(point => rgx.Matches(point)))
            {
                path.AddPoint(new Point3D()
                {
                    X = Convert.ToDouble(matches[0].Value),
                    Y = Convert.ToDouble(matches[1].Value),
                    Z = Convert.ToDouble(matches[2].Value),
                });
            }

            return path;
        }

        public static void SavePaths(Path path)
        {
            var fileStream = new FileStream(FileName, FileMode.OpenOrCreate);

            var strBuilder = new StringBuilder();

            foreach (var point in path.Sequence)
                strBuilder.Append(point + "*");

            using (var strWriter = new StreamWriter(fileStream, Encoding.UTF8))
                strWriter.Write(strBuilder.ToString().TrimEnd('*'));
        }
    }
}
