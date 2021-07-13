using System;
using System.Reflection;

namespace _9_Indexers
{
    // <<< = = = ИНДЕКСАТОРЫ = = = >>>
    class Program
    {
        static void Main(string[] args)
        {
            TownsExample();
        }
        static void TownsExample()
        {
            City[] cities = new City[]{ new City("Kirow"),
                                        new City("Moscow"),
                                        new City("Kaliningrad") };
            var towns = new Towns(cities);
            for (int i = 0; i < towns.CitiesCount; i++)
            {
                var city = towns[i];
                Console.WriteLine(city.Name);
            }
            int lastCityIndex = towns.CitiesCount - 1;
            towns[lastCityIndex] = new City("Novosibirsk");
            Console.WriteLine(towns[lastCityIndex]);
        }
        static void PeopleExample() 
        { 

        }
    }
    
    class Towns
    {
        public City[] Cities { get; private set; }
        public City this [int index] // indexer
        {
            get => Cities[index];
            set => Cities[index] = value;
        }
        public int CitiesCount;
        public Towns(City[] cities)
        {
            SetCities(cities);
        }
        private void SetCities(City[] cities)
        {
            Cities = cities;
            CitiesCount = cities.Length;
        }
    }

    class City
    {
        public string Name { get; set; }
        public City(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }

}
