namespace SchoolClasses.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDiscipline
    {
        string Name { get;  }

        int LectureCount { get; }

        int ExerciseCount { get;  }
    }
}
