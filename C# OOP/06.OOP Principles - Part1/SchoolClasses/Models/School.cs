using System.Collections.Generic;
using SchoolClasses.Contracts;

namespace SchoolClasses.Models
{
    public class School
    {
        public IEnumerable<IHuman> Humans { get; set; }
    }
}
