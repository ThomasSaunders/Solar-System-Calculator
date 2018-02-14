namespace SolarSystemCalculator
{
    class Planet
    {
        private static string PlanetName;
        private static double PlanetMass, PlanetDistance;

        public static void SetPlanetName(string name)
        {
            PlanetName = name;
        }

        public static string GetPlanetName()
        {
            return PlanetName;
        }

        public static void SetPlanetMass(double mass)
        {
            PlanetMass = mass;
        }

        public static double GetPlanetMass()
        {
            return PlanetMass;
        }

        public static void SetPlanetDistance(double distance)
        {
            PlanetDistance = distance;
        }

        public static double GetPlanetDistance()
        {
            return PlanetDistance;
        }

    }
}
