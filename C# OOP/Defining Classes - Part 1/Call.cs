namespace Defining_Classes___Part_1
{
    using System;

    public class Call
    {
        public static decimal PriceForCall = 0.37m;

        public Call() : this(null) { }
        public Call(DateTime? date) : this(date, null) { }
        public Call(DateTime? date, DateTime? time) : this(date, time, null) { }
        public Call(DateTime? date, DateTime? time, string dialedPhoneNum) : this(date, time,dialedPhoneNum, 0) { }
        public Call(DateTime? date, DateTime? time, string dialedPhoneNum, double seconds)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhoneNum = dialedPhoneNum;
            this.Seconds = seconds;
        }

        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public string DialedPhoneNum { get; set; }
        public double Seconds { get; set; }

        public override string ToString()
        {
            return $"Date: {Date}\n" +
                   $"Time: {Time}\n" +
                   $"DialedPhoneNum: {DialedPhoneNum}\n" +
                   $"Seconds: {Seconds}\n";
        }
    }
}
