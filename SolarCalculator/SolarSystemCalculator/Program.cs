using System;
using System.Collections.Generic;

namespace SolarSystemCalculator
{
    class Program
    {
        public static Planet Mercury = new Planet();
        public static Planet Venus = new Planet();
        public static Planet Earth = new Planet();
        public static Planet Mars = new Planet();
        public static Planet Jupiter = new Planet();
        public static Planet Saturn = new Planet();
        public static Planet Uranus = new Planet();
        public static Planet Neptune = new Planet();
        public static Planet Pluto = new Planet();

        public static void Main(string[] args)
        {
            SetPlanetInformation();
            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", Mercury.GetPlanetName(), Mercury.GetPlanetMass(), Mercury.GetPlanetDistance());
            Console.Read();
        }

        private static void SetPlanetInformation()
        {
            Boolean MassDone = false;
            Boolean DistanceDone = false;

            Double Mass, Distance;

            Mercury.SetPlanetName("Mercury");
            Venus.SetPlanetName("Venus");
            Earth.SetPlanetName("Earth");
            Mars.SetPlanetName("Mars");
            Jupiter.SetPlanetName("Jupiter");
            Saturn.SetPlanetName("Saturn");
            Uranus.SetPlanetName("Uranus");
            Neptune.SetPlanetName("Neptune");
            Pluto.SetPlanetName("Pluto");

            do
            {
                Console.WriteLine("Please enter the mass of {0} in kg", Mercury.GetPlanetName());
                MassDone = Double.TryParse(Console.ReadLine(), out Mass);
                Mercury.SetPlanetMass(Mass);

                Console.WriteLine("Please enter the distance of {0} from the sun in m", Mercury.GetPlanetName());
                DistanceDone = Double.TryParse(Console.ReadLine(), out Distance);
                Mercury.SetPlanetDistance(Distance);

            } while (MassDone == false || DistanceDone == false);
        }
    }
}