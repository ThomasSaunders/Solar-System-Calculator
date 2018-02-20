namespace SolarSystemCalculator
{
    public class Planet
    {
        public string PlanetName { get; set; }
        public double PlanetMass { get; set; }
        public double PlanetDistance { get; set; }
        public double CentreOfMass { get; set; }

        public Planet(string name, double mass = 0, double distance = 0)
        {
            PlanetName = name;
            PlanetMass = mass;
            PlanetDistance = distance;
        }
    }
}
