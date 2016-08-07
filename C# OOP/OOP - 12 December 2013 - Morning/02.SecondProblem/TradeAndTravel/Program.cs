namespace TradeAndTravel
{
    using TradeAndTravel.Extend;

    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine(new InteractionManagerExt());
            engine.Start();
        }
    }
}
