using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode1
{
    class Program
    {
        static void Main()
        {
            int sumFuel;
            sumFuel = 0;
            string[] masses = Read("masses.txt");
            for (int i = 0; i < masses.Length; i++)
            {
                int fuel = (int.Parse(masses[i])/3) - 2;
                Console.WriteLine($"- For a mass of {int.Parse(masses[i]),6}, the fuel required is {fuel,5}.\n");
                sumFuel = sumFuel + fuel;
            }
            Console.WriteLine($" The sum of the fuel required for all of the modules on your spacecraft is {sumFuel}.\n");
        }

        static string[] Read(string path)
        {
            StreamReader sr = new StreamReader(path);

            string file = sr.ReadToEnd();
            string[] values = file.Split('\n');

            sr.Close();
            return values;
        }
    }
}
