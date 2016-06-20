using System;
using System.Linq;

namespace Defining_Classes___Part_1
{

    public class GsmCallHistoryTest
    {
        public static void GsmCallHistoryTestMain()
        {
            var gsm = new Gsm("S2");

            gsm.AddCall(new Call(DateTime.Now.Date, DateTime.Now, "0888306256", 152));
            gsm.AddCall(new Call(DateTime.Now.Date, DateTime.Now, "112", 192));
            gsm.AddCall(new Call(DateTime.Now.Date, DateTime.Now, "112", 173));
            gsm.AddCall(new Call(DateTime.Now.Date, DateTime.Now, "0888306256", 282));

            gsm.CallHistory.ForEach(x => Console.WriteLine(x.ToString()));

            Console.WriteLine(gsm.TotalPriceOfCalls());

            var callToRemove = gsm.CallHistory.Where(x => x.Seconds == gsm.CallHistory.Max(v => v.Seconds)).Select(x => x).FirstOrDefault();

            gsm.CallHistory.Remove(callToRemove);

            Console.WriteLine(gsm.TotalPriceOfCalls());

            gsm.CallHistory.ForEach(x => Console.WriteLine(x.ToString()));

            gsm.CallHistory.Clear();
        }
    }
}
