namespace ArmyOfCreatures.Logic.Specialties
{
    using System;
    using Battles;
    using System.Text;

    public class DoubleAttackWhenAttacking : Specialty
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }

            this.rounds = rounds;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle deffender)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (deffender == null)
            {
                throw new ArgumentNullException("deffender");
            }

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return;
            }

            attackerWithSpecialty.CurrentAttack *= 2;
            this.rounds--;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append(this.GetType().Name + "(" + rounds + ")");

            return strBuilder.ToString();
        }
    }
}
