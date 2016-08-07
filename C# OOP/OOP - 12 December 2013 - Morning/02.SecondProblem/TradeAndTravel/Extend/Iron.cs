namespace TradeAndTravel.Extend
{
    public class Iron : Item
    {
        private const int GeneralItemValue = 3;

        public Iron(string name, Location location = null)
            : base(name, GeneralItemValue, ItemType.Iron, location)
        {
        }
    }
}
