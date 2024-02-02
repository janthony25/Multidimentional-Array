using System;

namespace Multidimentional
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[,] parkingLot =
            {
                {"Mustang", "F-150", "Explorer" },
                {"Corvette", "Camaro", "Silverdo" },
                {"Corolla", "Camry", "Rav4" }
            };

            parkingLot[0, 0] = "Mercedes Benz";
            /*
            Console.WriteLine(parkingLot[1,2]);
            Console.WriteLine(parkingLot[0,0]);
            */

            /*
            Console.WriteLine("\n\nList of cars");
            foreach (var car in parkingLot)
            {
                Console.WriteLine($"{car}\n\n");
            }
            */

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j <parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}