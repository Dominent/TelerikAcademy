namespace WarMachines.Machines
{
    using Interfaces;
    using System.Text;
    public class Tank : Machine, ITank
    {
        public Tank(string setName, double setAttackPoints, double setDefensePoints)
            : base(setName, setAttackPoints, setDefensePoints, 100)
        {
            ToggleDefenseMode();
        }

        public bool DefenseMode { get; set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
                this.DefenseMode = false;
            }
            else
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
                this.DefenseMode = true;
            }
        }
    }
}