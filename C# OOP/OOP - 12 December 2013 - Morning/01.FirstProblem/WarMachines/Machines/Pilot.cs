namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using Interfaces;
    using System.Text;
    using System.Linq;

    public class Pilot : IPilot
    {
        private IList<IMachine> machines;
        private readonly string name;

        public Pilot(string setName)
        {
            machines = new List<IMachine>();
            this.name = setName;
        }

        public string Name { get { return this.name; } }

        public void AddMachine(IMachine machine)
        {
            machines.Add(machine);
        }

        public string Report()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine(string.Format("{0} - {1} {2}", this.Name,
                machines.Count == 0 ? "no" : machines.Count.ToString(),
                machines.Count == 1 ? "machine": "machines"));

            var orderedMachines =
                from x in machines
                orderby x.HealthPoints, x.Name
                select x;


            foreach (var item in orderedMachines)
            {
                strBuilder.AppendLine(item.ToString());
            }
            return strBuilder.ToString().Trim();
        }
    }
}
