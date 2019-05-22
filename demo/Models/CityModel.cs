using System;

namespace dotnet.Models
{
    //.Where( x => x.Continent == "Westeros").ToList();
    public class CityModel
    {
        public string Name { get; set; }
        public string Continent { get; set; }

        public CityModel() { }

        public CityModel(string _name, string _continent) 
        {
            Name = _name;
            Continent = _continent;
        }

    }
}
