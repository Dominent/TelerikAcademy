namespace IntergalacticTravel.Tests.Fakes
{
    using System.Collections.Generic;
    using Contracts;

    internal class TeleportStationFake : TeleportStation
    {
        public TeleportStationFake(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) 
            : base(owner, galacticMap, location) { }

        public IResources Resources { get { return base.resources; } }
        public IBusinessOwner Owner { get { return base.owner; } }
        public ILocation Location { get { return base.location; } }
        public IEnumerable<IPath> GalacticMap { get { return base.galacticMap; } }
    }
}
