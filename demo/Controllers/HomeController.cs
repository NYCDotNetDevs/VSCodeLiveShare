using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        private List<CityModel> GetCities() 
        {
            List<CityModel> listOfCities = new List<CityModel>();

            listOfCities.Add(new CityModel("Dorne","Westeros"));
            listOfCities.Add(new CityModel("The Eyrie","Westeros"));
            listOfCities.Add(new CityModel("Casterly Rock","Westeros"));
            listOfCities.Add(new CityModel("King's Landing","Westeros"));
            listOfCities.Add(new CityModel("Dragonstone","Westeros"));
            listOfCities.Add(new CityModel("Harrenhal","Westeros"));
            listOfCities.Add(new CityModel("Oldtown","Westeros"));
            listOfCities.Add(new CityModel("Riverrun","Westeros"));
            listOfCities.Add(new CityModel("The Twins","Westeros"));
            listOfCities.Add(new CityModel("Winterfell","Westeros"));
            listOfCities.Add(new CityModel("Storm's End","Westeros"));
            listOfCities.Add(new CityModel("Braavos","Essos"));
            listOfCities.Add(new CityModel("Qarth","Essos"));
            listOfCities.Add(new CityModel("Meereen","Essos"));

            return listOfCities;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Westeros()
        {
            var WesterosCities = GetCities();

            return View(WesterosCities);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
