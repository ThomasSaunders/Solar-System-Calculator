namespace SolarSystemCalculator
{
    public class Planet
    {
        // Variables for each property of the planet
        public string PlanetName { get; set; }
        public double PlanetMass { get; set; }
        public double PlanetDistance { get; set; }
        public double CentreOfMass { get; set; }

        /* Instance constructor that requires the name of the planet as a parameter
         * The mass of the planet and distance can also be provided when the planet is initalised but is not required */
        public Planet(string name, double mass = 0, double distance = 0)
        {
            PlanetName = name;
            PlanetMass = mass;
            PlanetDistance = distance;
        }
    }
}