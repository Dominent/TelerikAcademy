namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Abstract;
    using Common.Enums;

    public class VinBenzin : Driver
    {
        public VinBenzin()
            : base("Vin Benzin", GenderType.Male)
        {
        }
    }
}
