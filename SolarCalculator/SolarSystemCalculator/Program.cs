using System;
using System.Diagnostics;

namespace SolarSystemCalculator
{
    class Program
    {
        
        /* Declare all of the planets.  Example data is provided from the Nasa Planets Fact Sheet.
         * Template for variable decleration
         * new planet(name, mass, distance from the sun) */
        public static Planet Mercury = new Planet("Mercury", 0.330E24, 57.9E9);
        public static Planet Venus = new Planet("Venus", 4.87E24, 108.2E9);
        public static Planet Earth = new Planet("Earth", 5.97E24, 149.6E9);
        public static Planet Mars = new Planet("Mars", 0.642E24, 227.9E9);
        public static Planet Jupiter = new Planet("Jupiter", 1898E24, 778.6E9);
        public static Planet Saturn = new Planet("Saturn", 568E24, 1433.5E9);
        public static Planet Uranus = new Planet("Uranus", 86.8E24, 2872.5E9);
        public static Planet Neptune = new Planet("Neptune", 102E24, 4495.1E9);
        public static Planet Pluto = new Planet("Pluto", 0.0146E24, 5906.4E9);
        public static Planet sun = new Planet("Sun", 1.989E30); /* Sun has a distance of 0 from the sun, 
                                                                 * and therefore not required in the decleration
                                                                 * as 0 is a default value. */

        public static double TotalMass; /* Variable required to hold the total mass of the planets that have
                                         * already had their centre of mass calculated to make the maths easier */

        public static void Main(string[] args)
        {
            double TotalCentreOfMass = 0; // Variable for holding the centre of mass.

            /* Code for changing the information about the planets, should the user want to.
             * Optional because the data was already inputted when the planets were initialised */
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

            // Write to the debug console the data for each planet
            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Mercury.PlanetName, Mercury.PlanetMass, Mercury.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Venus.PlanetName, Venus.PlanetMass, Venus.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Earth.PlanetName, Earth.PlanetMass, Earth.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Mars.PlanetName, Mars.PlanetMass, Mars.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Jupiter.PlanetName, Jupiter.PlanetMass, Jupiter.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Saturn.PlanetName, Saturn.PlanetMass, Saturn.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Uranus.PlanetName, Uranus.PlanetMass, Uranus.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Neptune.PlanetName, Neptune.PlanetMass, Neptune.PlanetDistance);

            Debug.WriteLine("Mass of {0} is {1} kg, and the distance from the sun is {2} m.", 
                Pluto.PlanetName, Pluto.PlanetMass, Pluto.PlanetDistance);

            Console.Clear();

            /* Calculate the centre of mass for each planet
             * Parsing each planet to the function and the centre of mass that has already been calculated 
             * Then write to the debug console what the current centre of mass is.*/
            TotalCentreOfMass = CalculateCentreOfMass(Mercury, TotalCentreOfMass); /* The total centre of mass parsed 
                                                                                    * to the function will always be 0 */
            // Write the centre of mass to the debug console.
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

            // Output the centre of mass that is calculated, converting it to standard form.
            Console.WriteLine("The centre of mass of the solar system is: {0} metres from the sun.", 
                TotalCentreOfMass.ToString("0.000E0"));

            // Read from the console to pause the program until the user is ready to exit the program.
            Console.Read();
        }

        // Function for calculating the centre of mass.
        private static double CalculateCentreOfMass(Planet planet, double LastCentreOfMass)
        {
            // Calculate the distance that the planet is from the last centre of mass location
            double PlanetDistance = planet.PlanetDistance - LastCentreOfMass;

            // Calculate the centre of mass between the planet and the last centre of mass/planet
            planet.CentreOfMass = (planet.PlanetMass * PlanetDistance) / (sun.PlanetMass + TotalMass);

            // Add the planets mass to the centre of mass
            TotalMass += planet.PlanetMass;

            // Return the centre of mass
            return planet.CentreOfMass;
        }

        /* Function for setting the planet information
         * This information is provided when the planet is initialised.
         * However, the user can customise the information should they wish to. */
        private static void SetPlanetInformation(Planet planet)
        {
            Boolean MassDone = false;
            Boolean DistanceDone = false;

            // Veriables that hold the data whilst it is being processed
            Double Mass, Distance;

            /* Do While Loop to stop the user from entering invalid data
             * the user may not need to trigger the loop if the data is valid on the first entry
             * The mass input and the distance from the sun must be valid before the user can continue. */
            do
            {
                // Taking mass information
                Console.WriteLine("Please enter the mass of {0} in kg", planet.PlanetName);
                MassDone = Double.TryParse(Console.ReadLine(), out Mass);
                planet.PlanetMass = Mass;

                // Taking distance from the sun information
                Console.WriteLine("Please enter the distance of {0} from the sun in m", planet.PlanetName);
                DistanceDone = Double.TryParse(Console.ReadLine(), out Distance);
                planet.PlanetDistance = Distance;

                if(MassDone == false || DistanceDone == false)
                    Console.WriteLine("Value(s) invalid. Please try again.");

                Console.Clear();

            } while (MassDone == false || DistanceDone == false);
        }
    }
}