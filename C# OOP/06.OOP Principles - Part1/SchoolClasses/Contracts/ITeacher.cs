namespace SchoolClasses.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITeacher : IHuman
    {
        IEnumerable<IDiscipline> Disciplines { get; set; }
    }
}
