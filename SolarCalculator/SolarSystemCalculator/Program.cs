﻿using System;
using System.Diagnostics;

namespace SolarSystemCalculator
{
    class Program
    {
        public static Planet Mercury = new Planet("Mercury", 0.330E24, 57.9E9);
        public static Planet Venus = new Planet("Venus", 4.87E24, 108.2E9);
        public static Planet Earth = new Planet("Earth", 5.97E24, 149.6E9);
        public static Planet Mars = new Planet("Mars", 0.642E24, 227.9E9);
        public static Planet Jupiter = new Planet("Jupiter", 1898E24, 778.6E9);
        public static Planet Saturn = new Planet("Saturn", 568E24, 1433.5E9);
        public static Planet Uranus = new Planet("Uranus", 86.8E24, 2872.5E9);
        public static Planet Neptune = new Planet("Neptune", 102E24, 4495.1E9);
        public static Planet Pluto = new Planet("Pluto", 0.0146E24, 5906.4E9);
        public static Planet sun = new Planet("Sun", 1.989E30, 0);

        public static double TotalMass;

        public static void Main(string[] args)
        {
            double TotalCentreOfMass;
            Console.WriteLine("Would you like to adjust the default values, which are based on the 'planet fact sheet' from NASA? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                SetPlanetInformation(Mercury);
                SetPlanetInformation(Venus);
                SetPlanetInformation(Earth);
                SetPlanetInformation(Mars);
                SetPlanetInformation(Jupiter);
                SetPlanetInformation(Saturn);
                SetPlanetInformation(Uranus);
                SetPlanetInformation(Neptune);
                SetPlanetInformation(Pluto);
            }
            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Mercury.GetPlanetName(), Mercury.GetPlanetMass(), Mercury.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Venus.GetPlanetName(), Venus.GetPlanetMass(), Venus.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Earth.GetPlanetName(), Earth.GetPlanetMass(), Earth.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Mars.GetPlanetName(), Mars.GetPlanetMass(), Mars.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Jupiter.GetPlanetName(), Jupiter.GetPlanetMass(), Jupiter.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Saturn.GetPlanetName(), Saturn.GetPlanetMass(), Saturn.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Uranus.GetPlanetName(), Uranus.GetPlanetMass(), Uranus.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Neptune.GetPlanetName(), Neptune.GetPlanetMass(), Neptune.GetPlanetDistance());

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Pluto.GetPlanetName(), Pluto.GetPlanetMass(), Pluto.GetPlanetDistance());

            Console.Clear();

            TotalCentreOfMass = CalculateCentreOfMass(Mercury, 0);
            Debug.WriteLine(TotalCentreOfMass.ToString());
            
            TotalCentreOfMass += CalculateCentreOfMass(Venus, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Earth, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Mars, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Jupiter, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Saturn, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Uranus, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Neptune, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            TotalCentreOfMass += CalculateCentreOfMass(Pluto, TotalCentreOfMass);
            Debug.WriteLine(TotalCentreOfMass.ToString());

            Console.WriteLine("The centre of mass of the solar system is: {0} metres ({1} metres to 3dp) from the sun.", 
                TotalCentreOfMass.ToString("0.000E0"), Math.Round(TotalCentreOfMass, 3).ToString("0.000E0"));

            Console.Read();
        }

        private static double CalculateCentreOfMass(Planet planet, double LastCentreOfMass)
        {
            double PlanetDistance = planet.GetPlanetDistance() - LastCentreOfMass;

            planet.SetCentreOfMass((planet.GetPlanetMass() * PlanetDistance) / (sun.GetPlanetMass() + TotalMass));

            TotalMass += planet.GetPlanetMass();

            return planet.GetCentreOfMass();
        }

        private static void SetPlanetInformation(Planet planet)
        {
            Boolean MassDone = false;
            Boolean DistanceDone = false;

            Double Mass, Distance;

            do
            {
                Console.WriteLine("Please enter the mass of {0} in kg", planet.GetPlanetName());
                MassDone = Double.TryParse(Console.ReadLine(), out Mass);
                planet.SetPlanetMass(Mass);

                Console.WriteLine("Please enter the distance of {0} from the sun in m", planet.GetPlanetName());
                DistanceDone = Double.TryParse(Console.ReadLine(), out Distance);
                planet.SetPlanetDistance(Distance);

                if(MassDone == false || DistanceDone == false)
                {
                    Console.WriteLine("Value(s) invalid. Please try again.");
                }

                Console.Clear();

            } while (MassDone == false || DistanceDone == false);
        }
    }
}