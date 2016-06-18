using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            byte managerAge = Convert.ToByte(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} (age: {6}, tel. {7})",
                companyName,
                companyAddress,
                phoneNumber,
                string.IsNullOrWhiteSpace(faxNumber) ? "(no fax)" : faxNumber,
                webSite,
                managerFirstName + " " + managerLastName,
                managerAge,
                managerPhone
                );
        }
    }
}
