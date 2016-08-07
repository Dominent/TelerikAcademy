namespace ArmyOfCreatures.Extended
{
    using Creatures;
    using Logic;
    using Logic.Creatures;

    public class CreaturesFactoryExt : CreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "Goblin":
                    return new Goblin();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Griffin":
                    return new Griffin();
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    return base.CreateCreature(name);
            }
        }
    }
}
