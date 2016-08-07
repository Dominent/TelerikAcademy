namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

    public class NissanGTR : MotorVehicle
    {
        public NissanGTR() 
            : base(125000, 1850000, 300, 45)
        {
        }
    }
}
