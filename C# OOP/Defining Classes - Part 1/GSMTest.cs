using System.Linq;

namespace Defining_Classes___Part_1
{
    using System;

    public class GsmTest
    {
        public static void GsmTestMain()
        {
            var gsmArray = new Gsm[]
            {
                new Gsm("S3", "Samsung", 892.5m, "Pesho", new Battery("Toshiba", DateTime.Now, DateTime.MaxValue, BatteryType.NiMH), new Display(14.5d, 123890000)),
                new Gsm("JM2", "Huawei", 892.5m, "Ivan", new Battery("Toshiba", DateTime.Now, DateTime.MaxValue, BatteryType.NiMH), new Display(14.5d, 123890000)),
                new Gsm("Xp", "Sony", 892.5m, "Penka", new Battery("Toshiba", DateTime.Now, DateTime.MaxValue, BatteryType.NiMH), new Display(14.5d, 123890000)),
            };

            gsmArray.ToList().ForEach(x => Console.WriteLine(x.ToString()));

            Gsm.IPhone4S = 123;
            Console.WriteLine(Gsm.IPhone4S);
        }
    }
}
