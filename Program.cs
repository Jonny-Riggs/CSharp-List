using System;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetListTwo = new List<string>(){"Saturn", "Uranus"};

            planetList.AddRange(planetListTwo);

            planetList.Insert(1, "Earth");
            planetList.Insert(2, "Venus");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 6);

            planetList.Remove("Pluto");


            // foreach (Object rocky in rockyPlanets)
            // {
            //     Console.WriteLine(rocky);
            // }

            foreach (Object planet in planetList)
            {
                Console.WriteLine(planet);
            }


        }
    }
}