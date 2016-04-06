using System;

class Age
{
    static void Main()
    {
        DateTime input = new DateTime();

        input = Convert.ToDateTime(Console.ReadLine());

        int ageNow = 0;
        int now = 2015;
        ageNow = (now - input.Year) <= 0 ? ageNow = 0 : ageNow = now - input.Year;
        Console.WriteLine("{0}\n{1}", ageNow, (ageNow + 10));
    }
}

