using System;

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
        public static Planet sun = new Planet("Sun", 1.989E-30, 0);

        public static double TotalMass;

        public static void Main(string[] args)
        {
            double TotalCentreOfMass;

            SetPlanetInformation(Mercury);
            SetPlanetInformation(Venus);
            SetPlanetInformation(Earth);
            SetPlanetInformation(Mars);
            SetPlanetInformation(Jupiter);
            SetPlanetInformation(Saturn);
            SetPlanetInformation(Uranus);
            SetPlanetInformation(Neptune);
            SetPlanetInformation(Pluto);

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Mercury.GetPlanetName(), Mercury.GetPlanetMass(), Mercury.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Venus.GetPlanetName(), Venus.GetPlanetMass(), Venus.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Earth.GetPlanetName(), Earth.GetPlanetMass(), Earth.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Mars.GetPlanetName(), Mars.GetPlanetMass(), Mars.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Jupiter.GetPlanetName(), Jupiter.GetPlanetMass(), Jupiter.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Saturn.GetPlanetName(), Saturn.GetPlanetMass(), Saturn.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Uranus.GetPlanetName(), Uranus.GetPlanetMass(), Uranus.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Neptune.GetPlanetName(), Neptune.GetPlanetMass(), Neptune.GetPlanetDistance());

            Console.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Pluto.GetPlanetName(), Pluto.GetPlanetMass(), Pluto.GetPlanetDistance());

            Console.Clear();

            TotalCentreOfMass = CalculateCentreOfMass(Mercury, 0);
            TotalCentreOfMass += CalculateCentreOfMass(Venus, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Earth, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Mars, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Jupiter, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Saturn, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Uranus, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Neptune, TotalCentreOfMass);
            TotalCentreOfMass += CalculateCentreOfMass(Pluto, TotalCentreOfMass);

            Console.WriteLine("The centre of mass of the solar system is: {0} metres from the sun.", 
                TotalCentreOfMass.ToString());

            Console.Read();
        }

        private static double CalculateCentreOfMass(Planet planet, double LastCentreOfMass)
        {
            double PlanetDistance = planet.GetPlanetDistance() - LastCentreOfMass;

            TotalMass += planet.GetPlanetMass();

            planet.SetCentreOfMass((planet.GetPlanetMass() * PlanetDistance) / (sun.GetPlanetMass() + TotalMass));

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
    }l
}