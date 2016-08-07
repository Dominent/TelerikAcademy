namespace ArmyOfCreatures.Logic.Specialties
{
    using System;
    using Battles;
    using System.Text;
    public class AddAttackWhenSkip : Specialty
    {
        private readonly int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd < 1 || attackToAdd > 20)
            {
                throw new ArgumentOutOfRangeException("defenseToAdd", "defenseToAdd should be between 1 and 20, inclusive");
            }

            this.attackToAdd = attackToAdd;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append(this.GetType().Name + "(" + attackToAdd + ")");

            return strBuilder.ToString();
        }
    }
}
