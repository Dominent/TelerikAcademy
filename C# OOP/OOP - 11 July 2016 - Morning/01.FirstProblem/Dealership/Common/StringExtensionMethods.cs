
namespace Dealership.Common
{
    using Enums;
    using System;

    public static class StringExtensionMethods
    {
        public static Role ParseRole(this string input)
        {
            switch (input)
            {
                case "Normal":
                    return Role.Normal;
                case "VIP":
                    return Role.VIP;
                case "Admin":
                    return Role.Admin;
            }

            throw new ArgumentException(Constants.InvalidRoleInput);
        }

    }
}
