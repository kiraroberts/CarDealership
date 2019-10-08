using Microsoft.AspNetCore.Mvc;
using Dealerships.Models;
using System.Collections.Generic;

namespace Dealerships.Controllers

{
    public class DealershipsController : Controller 
    {
       
        [HttpGet("/autos")]
        public ActionResult Index()
        {
        Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
        Car yugo = new Car("1980 Yugo Koral", 700, 56000);
        Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
        Car amc = new Car("1976 AMC Pacer", 400, 198000);
        

        List<Car> allItems = Car.GetAll();
        return View(allItems);
        //gives access to all new car instances for the search
        }

        [HttpGet("/autos/new")]
        public ActionResult CreateForm()
        //this matches the name of the cshtml file
        {
            return View();
        }


        [HttpPost("/autos")]
        public ActionResult Search(int maxPrice, int maxMiles)
        //this name doesn't matter because the Index redirect
        {
            Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
            Car yugo = new Car("1980 Yugo Koral", 700, 56000);
            Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
            Car amc = new Car("1976 AMC Pacer", 400, 198000);
        

            List<Car> allItems = Car.GetAll();
            
            List<Car> CarsMatchingSearch = new List<Car>(0); 

            foreach (Car automobile in allItems)
            if (automobile.WorthBuying(maxPrice) && automobile.LowMileage(maxMiles))
                {
                    CarsMatchingSearch.Add(automobile);
                }
                else
                {
                
                }
    

            return RedirectToAction("Index",CarsMatchingSearch);
            //With a Post method there is no view, this is the last command for where to send it, if it is View() it's showing the [HttpGet] 
        }

      



    }
}