namespace SolarSystemCalculator
{
    public class Planet
    {
        private string PlanetName;
        private double PlanetMass;
        private double PlanetDistance;
        private double CentreOfMass;

        public Planet(string name, double mass = 0, double distance = 0)
        {
            PlanetName = name;
            PlanetMass = mass;
            PlanetDistance = distance;
        }
        
        public void SetPlanetName(string name)
        {
            PlanetName = name;
        }

        public string GetPlanetName()
        {
            return PlanetName;
        }

        public void SetPlanetMass(double mass)
        {
            PlanetMass = mass;
        }

        public double GetPlanetMass()
        {
            return PlanetMass;
        }

        public void SetPlanetDistance(double distance)
        {
            PlanetDistance = distance;
        }

        public double GetPlanetDistance()
        {
            return PlanetDistance;
        }

        public void SetCentreOfMass(double centre)
        {
            CentreOfMass = centre;
        }

        public double GetCentreOfMass()
        {
            return CentreOfMass;
        }
    }
}
