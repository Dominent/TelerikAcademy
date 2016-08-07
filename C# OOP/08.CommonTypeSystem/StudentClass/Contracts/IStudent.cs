namespace StudentClass.Contracts
{
    using Infrastructure.Enum;
    using System;

    public interface IStudent : ICloneable, IComparable<IStudent>
    {
        string Firstname { get; }

        string Lastname { get; }

        int Age { get; }

        ulong SSN { get; }

        string PermanentAddress { get; }

        string MobilePhone { get; }

        int Course { get; }

        SpecialityType Speciality { get; }

        UnivercityType Univercity { get; }

        FacultyType Faculty { get; }

        string Email { get; }
    }
}
