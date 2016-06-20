using System.Collections.Generic;
using System.Linq;

namespace Defining_Classes___Part_1
{
    class Gsm
    {
        private static int iPhone4S;

        public Gsm() : this(null) { }

        public Gsm(string model) : this(model, null) { }

        public Gsm(string model, string manufacturer) : this(model, manufacturer, null) { }

        public Gsm(string model, string manufacturer, decimal? price) : this(model, manufacturer, price, null) { }

        public Gsm(string model, string manufacturer, decimal? price, string owner) : this(model, manufacturer, price, owner, null) { }

        public Gsm(string model, string manufacturer, decimal? price, string owner, Battery battery) : this(model, manufacturer, price, owner, battery, null) { }

        public Gsm(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public List<Call> CallHistory { get; set; }

        public static int IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public void AddCall(Call call) => CallHistory.Add(call);

        public void RemoveCall(Call call) => CallHistory.Remove(call);

        public decimal TotalPriceOfCalls() => (decimal)CallHistory.Sum(call => call.Seconds) / (60m * Call.PriceForCall);

        public override string ToString() // check for null
        {
            return $"Model - {Model}" +
                   $"\nManufacturer - {Manufacturer}" +
                   $"\nPrice - {Price}" +
                   $"\nOwner - {Owner}" +
                   $"\nBattery Info : " +
                   $"\nModel - {Battery.Model}" +
                   $"\nBatteryType - {Battery.BatteryType}" +
                   $"\nHoursIdle - {Battery.HoursIdle}" +
                   $"\nHoursTalk - {Battery.HoursTalk}" +
                   $"\nDisplay Info : " +
                   $"\nSize - {Display.Size}" +
                   $"\nNumberOfColours - {Display.NumberOfColors}";
        }
    }
}
