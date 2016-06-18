using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamProblemThree
{
    class ExamProblemThree
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            char harryPoten = '@';

            int[] harryCoords = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int haryCounter = 0;

            var basiliskCount = Convert.ToInt32(Console.ReadLine());

            var pets = new Dictionary<char, List<int>>();

            for (int i = 0; i < basiliskCount; i++)
            {
                string[] basilisk = Console.ReadLine().Split(' ');

                char basName = Convert.ToChar(basilisk[0]);
                var basA = Convert.ToInt32(basilisk[1]);
                var basB = Convert.ToInt32(basilisk[2]);
                var basC = Convert.ToInt32(basilisk[3]);
                var basD = Convert.ToInt32(basilisk[4]);

                pets.Add(basName, new List<int>() { basA, basB, basC, basD });
            }
            string input = Console.ReadLine();
            bool[] gpsIsEqual = new bool[4];
            while (input != "END")
            {
                var formatedStr = input.Split(' ');

                var petName = Convert.ToChar(formatedStr[0]);
                var dim = (Convert.ToChar(formatedStr[1]) - 'A');
                var value = Convert.ToInt32(formatedStr[2]);

                char basNameEater = ' ';

                if (petName == '@')
                {
                    Array.Clear(gpsIsEqual, 0, gpsIsEqual.Length - 1);

                    if (((harryCoords[dim] + value) < dimensions[dim]))
                    {
                       
                        if ((harryCoords[dim] + value) < 0)
                            harryCoords[dim] = 0;
                        else
                            harryCoords[dim] += value;
                    }
                    else
                        harryCoords[dim] = dimensions[dim] - 1;

                    haryCounter++;

                    foreach (var pet in pets.Values)
                    {
                        for (int i = 0; i < pet.Count; i++)
                            gpsIsEqual[i] = pet[i] == harryCoords[i];

                        if (gpsIsEqual[0] && gpsIsEqual[1] && gpsIsEqual[2] && gpsIsEqual[3])
                        {
                            basNameEater = (pets.FirstOrDefault(x => x.Value == pet).Key);
                            break;
                        }
                    }
                    if (gpsIsEqual[0] && gpsIsEqual[1] && gpsIsEqual[2] && gpsIsEqual[3])
                    {
                        Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"", basNameEater, haryCounter);
                        Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", basNameEater);
                        break;
                    }
                }
                else
                {
                    Array.Clear(gpsIsEqual, 0, gpsIsEqual.Length - 1);

                    if (((pets[petName][dim] + value) < dimensions[dim]))
                    {
                        if ((pets[petName][dim] + value) < 0)
                            pets[petName][dim] = 0;
                        else
                            pets[petName][dim] += value;
                    }
                    else
                        pets[petName][dim] = dimensions[dim] - 1;

                    for (int i = 0; i < pets[petName].Count; i++)
                        gpsIsEqual[i] = (pets[petName][i] == harryCoords[i]);
                    if (gpsIsEqual[0] && gpsIsEqual[1] && gpsIsEqual[2] && gpsIsEqual[3])
                    {
                        Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", petName, haryCounter);
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (!(gpsIsEqual[0] && gpsIsEqual[1] && gpsIsEqual[2] && gpsIsEqual[3]))
                Console.WriteLine("{0}: \"I am the chosen one!\" - {1}", harryPoten, haryCounter);
        }
    }
}
