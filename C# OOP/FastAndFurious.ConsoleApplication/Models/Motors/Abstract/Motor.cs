namespace FastAndFurious.ConsoleApplication.Models.Motors.Abstract
{
    using Common.Enums;
    using Contracts;
    using Common.Utils;

    public abstract class Motor : IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        private readonly int id;
        private int weight;
        private int acceleration;
        private int topSpeed;
        private int horsepower;
        private decimal price;
        private TunningGradeType gradeType;
        private CylinderType cylinderType;
        private MotorType motorType;

        public Motor(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            int horsepower,
            TunningGradeType gradeType,
            CylinderType cylinderType,
            MotorType engineType)
        {
            this.id = DataGenerator.GenerateId();
            this.Acceleration = acceleration;
            this.Price = price;
            this.TopSpeed = topSpeed;
            this.Horsepower = horsepower;
            this.Weight = weight;
            this.GradeType = gradeType;
            this.CylinderType = cylinderType;
            this.EngineType = engineType;
        }

        public int Id { get { return this.id; } }

        public TunningGradeType GradeType
        {
            get { return this.gradeType; }
            private set { this.gradeType = value; }
        }

        public int Acceleration
        {
            get { return this.acceleration; }
            private set { this.acceleration = value; }
        }

        public int TopSpeed
        {
            get { return this.topSpeed; }
            private set { this.topSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            private set { this.weight = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }

        public int Horsepower
        {
            get { return this.horsepower; }
            private set { this.horsepower = value; }
        }

        public MotorType EngineType
        {
            get { return this.motorType; }
            private set { this.motorType = value; }
        }

        public CylinderType CylinderType
        {
            get { return this.cylinderType; }
            private set { this.cylinderType = value; }
        }
    }
}
