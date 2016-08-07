namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Common.Enums;
    using Contracts;
    using Common;
    using System.Text;
    public class User : IUser
    {
        private IList<IVehicle> vehicles;
        //private IList<IComment> comments;
        private string firstName;
        private string lastName;
        private string password;
        private string username;

        public User(string setUsername, string setFirstName, string setLastName, string setPassword, string setRole)
        {
            this.Username = setUsername;
            this.FirstName = setFirstName;
            this.LastName = setLastName;
            this.Password = setPassword;
            this.Role = setRole.ParseRole();

            this.vehicles = new List<IVehicle>();
            //this.comments = new List<IComment>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxNameLength, Constants.MinNameLength,
                   string.Format(Constants.StringMustBeBetweenMinAndMax,
                   "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxNameLength, Constants.MinNameLength,
                   string.Format(Constants.StringMustBeBetweenMinAndMax,
                   "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxPasswordLength, Constants.MinPasswordLength,
                  string.Format(Constants.StringMustBeBetweenMinAndMax,
                  "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));
                this.password = value;
            }
        }

        public Role Role { get; private set; }

        public string Username
        {
            get { return this.username; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxNameLength, Constants.MinNameLength,
                   string.Format(Constants.StringMustBeBetweenMinAndMax,
                   "Username", Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));
                this.username = value;
            }
        }

        //shallow copy
        public IList<IVehicle> Vehicles { get { return new List<IVehicle>(this.vehicles); } }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            Validator.ValidateNull(commentToAdd, Constants.CommentCannotBeNull);
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            if (this.Role == Role.Admin)
                throw new ArgumentException(string.Format(Constants.AdminCannotAddVehicles));
            if (this.Role != Role.VIP)
            {
                if (this.vehicles.Count < Constants.VipMaxVehicles)
                {
                    this.vehicles.Add(vehicle);
                }
                else
                {
                    throw new ArgumentException(String.Format(Constants.NotAnVipUserVehiclesAdd, Constants.VipMaxVehicles));
                }
            }
            else
            {
                this.vehicles.Add(vehicle);
            }
        }

        public string PrintVehicles()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format("--USER {0}--", this.username));
            var counter = 1;
            if (this.Vehicles.Count > 0)
            {
                foreach (var vehicle in this.Vehicles)
                {
                    strBuilder.Append(counter + "." + vehicle.ToString());
                    counter++;
                }
            }
            else
            {
                strBuilder.AppendLine("--NO VEHICLES--");
            }
            return strBuilder.ToString().Trim();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            Validator.ValidateNull(commentToRemove, Constants.CommentCannotBeNull);
            Validator.ValidateNull(vehicleToRemoveComment, Constants.VehicleCannotBeNull);

            if (commentToRemove.Author != this.Username)
                throw new ArgumentException(String.Format(Constants.YouAreNotTheAuthor));

            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            this.vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format("Username: {0}, FullName: {1} {2}, Role: {3}", this.Username, this.FirstName, this.LastName, this.Role));
            return strBuilder.ToString().Trim();
        }
    }
}
