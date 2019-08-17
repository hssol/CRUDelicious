using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class DishController : Controller
    {
        private MyContext dbContext;
        public DishController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
        // public int DishId { get; set; }
        // public string Name { get; set; }
        // public string Chef { get; set; }
        // public int Tastiness { get; set; }
        // public int Calories { get; set; }
        // public string Description { get; set; }
            List<Dish> AllDishes = dbContext.Dishes.OrderByDescending(d=>d.CreatedAt).ToList();
            return View("Index", AllDishes);
        }
        [HttpGet("createdish")]
        public IActionResult NewDish()
        {
            return View("NewDish");
        }

        [HttpPost("create")]
        public IActionResult Create(Dish aDish)
        {
            dbContext.Add(aDish);
            dbContext.SaveChanges();
            return Redirect("/");
        }
        [HttpGet("{DishId}")]
        public IActionResult ViewDish(int DishId)
        {
            Dish thisDish = dbContext.Dishes.FirstOrDefault(d=>d.DishId == DishId);
            return View("ViewDish", thisDish);
        }
        [HttpGet("editdish/{DishId}")]
        public IActionResult EditDish(int DishId)
        {
            Dish thisDish = dbContext.Dishes.FirstOrDefault(d=>d.DishId == DishId);
            return View("EditDish", thisDish);
        }
        [HttpPost("edit/{DishId}")]
        public IActionResult Edit(int DishId, Dish aDish)
        {
            Dish thisDish = dbContext.Dishes.FirstOrDefault(d=>d.DishId == DishId);
            thisDish.Name = aDish.Name;
            thisDish.Chef = aDish.Chef;
            thisDish.Calories = aDish.Calories;
            thisDish.Tastiness = aDish.Tastiness;
            thisDish.Description = aDish.Description;
            thisDish.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return Redirect("/");
        }

        [HttpGet("delete/{DishId}")]
        public IActionResult DeleteDish(int DishId)
        {
            Dish thisDish = dbContext.Dishes.FirstOrDefault(d=>d.DishId == DishId);
            dbContext.Dishes.Remove(thisDish);
            dbContext.SaveChanges();
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
