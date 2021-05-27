using System;

namespace planetMethod
{
    class Program
    {
        static double traveler_years = 0;
        static double planet_age;
        static double earth_time = 31557600;
        static double earth_traveler_time = 631154000;

        static void Main(string[] args)
        {            
            Program.earthSpaceAge(earth_time, earth_traveler_time);
            Program.planetAge(planet_age);
            
        }
        public static double earthSpaceAge(double earth_time, double earth_traveler_time)
        {
            planet_age  = Convert.ToDouble(earth_traveler_time/earth_time);
            Console.WriteLine("Earth age: " + Math.Round(planet_age,3));
            return planet_age;
        }
        
        public static double planetAge(double planet_age)
        {
            string [] planet = new string [4];
            planet [0] = "Mercury";
            planet [1] = "Mars";
            planet [2] = "Saturn";
            planet [3] = "Uranus";
            
            double [] age = new double [4];
            age [0] = 0.2408467;
            age [1] = 1.8808158;
            age [2] = 29.447498;
            age [3] = 84.016846;
                        
            for (int i = 0; i < planet.Length; i++)
            {
                double traveler_years = Math.Round(planet_age/age[i],3); 
                Console.WriteLine("Earth age: " + Math.Round(traveler_years,3) + 
                " Earth-years old- " + planet[i] + ": " + traveler_years + " Earth-years old");
            }

            return traveler_years;
        }
    }
}
