namespace Defining_Classes___Part_1
{
    using System;

    class Battery
    {
        public Battery() : this(null) { }

        public Battery(string model) : this(model, null) { }

        public Battery(string model, DateTime? hoursIdle) : this(model, hoursIdle, null) { }

        public Battery(string model, DateTime? hoursIdle, DateTime? hoursTalk) : this(model, hoursIdle, hoursTalk, BatteryType.Default) { }

        public Battery(string model, DateTime? hoursIdle, DateTime? hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model { get; set; }
        public BatteryType BatteryType { get; set; }
        public DateTime? HoursIdle { get; set; }
        public DateTime? HoursTalk { get; set; }

    }
}
