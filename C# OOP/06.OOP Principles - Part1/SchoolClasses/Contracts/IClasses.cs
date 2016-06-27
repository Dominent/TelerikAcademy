namespace SchoolClasses.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IClasses
    {
        IEnumerable<IStudent> Students { get; set; }

        IEnumerable<ITeacher> Teachers { get; set; }
    }
}