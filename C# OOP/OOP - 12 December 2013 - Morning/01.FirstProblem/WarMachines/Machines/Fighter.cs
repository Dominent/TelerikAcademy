namespace WarMachines.Machines
{
    using Interfaces;

    public class Fighter : Machine, IFighter
    {
        public Fighter(string setName, double setAttackPoints, double setDefensePoints, bool setStealthMode)
            : base(setName, setAttackPoints, setDefensePoints, 200)
        {
            this.StealthMode = setStealthMode;
        }

        public bool StealthMode { get; set; }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
                this.StealthMode = false;
            else
                this.StealthMode = true;
        }
    }
}
