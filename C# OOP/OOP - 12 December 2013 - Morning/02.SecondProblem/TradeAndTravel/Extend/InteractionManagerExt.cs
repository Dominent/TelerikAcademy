namespace TradeAndTravel.Extend
{
    using System.Linq;

    public class InteractionManagerExt : InteractionManager
    {
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    HandleCraftInteraction(actor, commandWords[2]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    return person = new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return item = new Weapon(itemNameString, itemLocation);
                case "wood":
                    return item = new Wood(itemNameString, itemLocation);
                case "iron":
                    return item = new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    return location = new Forest(locationName);
                case "mine":
                    return location = new Mine(locationName);
            }

            return base.CreateLocation(locationTypeString, locationName);
        }

        public void HandleGatherInteraction(Person actor, string itemName)
        {
            var inventory = actor.ListInventory().ToList();
            var weapon = inventory.Where(x => x is Weapon).FirstOrDefault();
            var armor = inventory.Where(x => x is Armor).FirstOrDefault();

            if (actor.Location is Forest)
                if (weapon != null)
                    actor.AddToInventory(new Wood(itemName, actor.Location));

            if (actor.Location is Mine)
                if (armor != null)
                    actor.AddToInventory(new Iron(itemName, actor.Location));
        }

        public void HandleCraftInteraction(Person actor, string itemName)
        {
            var inventory = actor.ListInventory().ToList();
            var iron = inventory.Where(x => x is Iron).FirstOrDefault();
            var wood = inventory.Where(x => x is Wood).FirstOrDefault();

            if (iron != null)
                actor.AddToInventory(new Armor(itemName, actor.Location));

            if (iron != null && wood != null)
                actor.AddToInventory(new Weapon(itemName, actor.Location));
        }
    }
}
