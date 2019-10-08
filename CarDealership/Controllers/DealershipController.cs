using Microsoft.AspNetCore.Mvc;
using Dealerships.Models;
using System.Collections.Generic;

namespace Dealerships.Controllers

{
    public class DealershipsController : Controller 
    {
        [HttpGet("/search")]
        public ActionResult Index()
        {
            // List<Item> allItems = Item.GetAll();
            // return View(allItems);
        }

        [HttpGet("/search/new")]
        public ActionResult CreateForm()
        {
            return View();
        }


        [HttpPost("/items-result")]
        public ActionResult Create(string description)
        {
            
            Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "great car");
            Car yugo = new Car("1980 Yugo Koral", 700, 56000, "great car");
            Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "great car");
            Car amc = new Car("1976 AMC Pacer", 400, 198000, "great car");
            
            List <Car> cars = new List <Car>() { volkswagen, yugo, ford, amc };


            return RedirectToAction("Index");
        }

            



    }
}