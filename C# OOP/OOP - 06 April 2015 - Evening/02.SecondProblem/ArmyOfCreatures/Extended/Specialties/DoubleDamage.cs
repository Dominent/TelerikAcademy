namespace ArmyOfCreatures.Extended.Specialties
{
    using Logic.Battles;
    using Logic.Specialties;
    using System;
    using System.Text;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            if (rounds < 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }
            else if (rounds > 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be less than or equal to 10");
            }
            this.rounds = rounds;
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds >= 0)
            {
                this.rounds--;
                return currentDamage * 2;
            }

            return currentDamage;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append(this.GetType().Name + "(" + rounds + ")");

            return strBuilder.ToString();
        }
    }
}

