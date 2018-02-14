using System;
using System.Collections.Generic;

namespace SolarSystemCalculator
{
    class Program
    {
        public static Planet Mercury = new Planet("Mercury");
        public static Planet Venus = new Planet("Venus");
        public static Planet Earth = new Planet("Earth");
        public static Planet Mars = new Planet("Mars");
        public static Planet Jupiter = new Planet("Jupiter");
        public static Planet Saturn = new Planet("Saturn");
        public static Planet Uranus = new Planet("Uranus");
        public static Planet Neptune = new Planet("Neptune");
        public static Planet Pluto = new Planet("Pluto");

        public static void Main(string[] args)
        {
            SetPlanetInformation();
            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", Mars.GetPlanetName(), Mars.GetPlanetMass(), Mars.GetPlanetDistance());
            Console.Read();
        }

        private static void SetPlanetInformation()
        {
            Boolean MassDone = false;
            Boolean DistanceDone = false;

            Double Mass, Distance;

            do
            {
                Console.WriteLine("Please enter the mass of {0} in kg", Mars.GetPlanetName());
                MassDone = Double.TryParse(Console.ReadLine(), out Mass);
                Mars.SetPlanetMass(Mass);

                Console.WriteLine("Please enter the distance of {0} from the sun in m", Mars.GetPlanetName());
                DistanceDone = Double.TryParse(Console.ReadLine(), out Distance);
                Mars.SetPlanetDistance(Distance);

            } while (MassDone == false || DistanceDone == false);
        }
    }
}