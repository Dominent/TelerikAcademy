namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using Interfaces;
    using System.Text;
    public abstract class Machine : IMachine
    {
        private double defencePoints;
        private double attackPoints;
        private double healthPoints;
        private string name;

        public Machine(string setName, double setAttackPoints, double setDefensePoints, double setHealthPoints)
        {
            this.name = setName;
            this.attackPoints = setAttackPoints;
            this.defencePoints = setDefensePoints;
            this.HealthPoints = setHealthPoints;
            this.Targets = new List<string>();
        }

        public double AttackPoints { get { return this.attackPoints; } protected set { this.attackPoints = value; } }
        public double DefensePoints { get { return this.defencePoints; } protected set { this.defencePoints = value; } }
        public double HealthPoints { get { return this.healthPoints; } set { this.healthPoints = value; } }

        public string Name { get { return this.name; } set { this.name = value; } }

        public IPilot Pilot { get; set; }

        public IList<string> Targets { get; set; }

        public void Attack(string target)
        {
            Targets.Add(target);
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine($"- {this.Name}");
            strBuilder.AppendLine($"  *Type: {this.GetType().Name}");
            strBuilder.AppendLine($"  *Health: {this.HealthPoints}");
            strBuilder.AppendLine($"  *Attack: {this.AttackPoints}");
            strBuilder.AppendLine($"  *Defense: {this.DefensePoints}");
            strBuilder.AppendLine(string.Format("  *Targets: {0}",
                this.Targets.Count == 0 ? "None" : string.Join(",", this.Targets)));
            if (this is ITank)
                strBuilder.AppendLine(string.Format("  *Defense: {0}", (this as Tank).DefenseMode ? "ON" : "OFF"));
            if (this is IFighter)
                strBuilder.AppendLine(string.Format("  *Stealth: {0}", (this as Fighter).StealthMode ? "ON" : "OFF"));

            return strBuilder.ToString().Trim();
        }
    }
}
