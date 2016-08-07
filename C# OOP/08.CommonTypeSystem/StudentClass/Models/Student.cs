namespace StudentClass.Models
{
    using Contracts;
    using Infrastructure.Enum;
    using System.Text;
    using System;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;

    [Serializable]
    public class Student : IStudent
    {
        private readonly string firstname;
        private readonly string lastname;
        protected int age;
        private readonly ulong ssn;
        private readonly string permanentAddress;
        private readonly string mobilePhone;
        protected int course;
        private readonly SpecialityType speciality;
        private readonly UnivercityType university;
        private readonly FacultyType faculty;
        private readonly string email;

        public Student(string setFirstName, string setLastName, int setAge, ulong setSSN, string setPermanentAddress, string setMobilePhone,
            int setCourse, SpecialityType setSpeciality, UnivercityType setUniversity, FacultyType setFaculty, string setEmail)
        {
            this.firstname = setFirstName;
            this.lastname = setLastName;
            this.Age = setAge;
            this.ssn = setSSN;
            this.permanentAddress = setPermanentAddress;
            this.mobilePhone = setMobilePhone;
            this.course = setCourse;
            this.speciality = setSpeciality;
            this.university = setUniversity;
            this.faculty = setFaculty;
            this.email = setEmail;

        }

        public string Firstname { get { return this.firstname; } }

        public string Lastname { get { return this.lastname; } }

        public int Age
        {
            get { return this.age; }
            protected set { this.age = value; }
        }

        public ulong SSN { get { return this.ssn; } }

        public string PermanentAddress { get { return this.permanentAddress; } }

        public string MobilePhone { get { return this.mobilePhone; } }

        public int Course { get { return this.course; } }

        public SpecialityType Speciality { get { return this.speciality; } }

        public UnivercityType Univercity { get { return this.university; } }

        public FacultyType Faculty { get { return this.faculty; } }

        public string Email { get { return this.email; } }

        public object Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(ms, this);

                ms.Position = 0;

                return formatter.Deserialize(ms);
            }
        }

        public int CompareTo(IStudent other)
        {
            if (this.Firstname.Length > other.Firstname.Length)
                return 1;
            if (this.Firstname.Length < other.Firstname.Length)
                return -1;

            if (this.Lastname.Length > other.Lastname.Length)
                return 1;
            if (this.Lastname.Length < other.Lastname.Length)
                return -1;

            if (this.SSN > other.SSN)
                return 1;
            if (this.SSN < other.SSN)
                return -1;

            return 0;
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            obj = obj as Student;

            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(new string('=', 10) + $" Student: {this.Firstname + " " + this.Lastname } " + new string('=', 10));
            strBuilder.AppendLine($"Age: {this.Age}");
            strBuilder.AppendLine($"SSN: {this.SSN}");
            strBuilder.AppendLine($"Permanent Address: {this.PermanentAddress}");
            strBuilder.AppendLine($"Mobile Phone: {this.MobilePhone}");
            strBuilder.AppendLine($"Course: {this.Course}");
            strBuilder.AppendLine($"Speciality: {this.Speciality}");
            strBuilder.AppendLine($"Univercity: {this.Univercity}");
            strBuilder.AppendLine($"Faculty: {this.Faculty}");
            strBuilder.AppendLine($"Email: {this.Email}");

            return strBuilder.ToString();
        }

        public override int GetHashCode()
        {
            return (firstname.GetHashCode() ^ lastname.GetHashCode()) ^
                    (ssn.GetHashCode() ^ age.GetHashCode());
        }
    }
}
