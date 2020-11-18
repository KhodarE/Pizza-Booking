using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GourmetPizza.Controllers
{
    public class PizzasStaticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Purchase(int PizzaType, int PizzaCount)
        {
            ViewData["PizzaType"] = PizzaType;
            if (PizzaType == 1)
            {
                ViewData["PizzaName"] = "BBQ Beef";
                ViewData["total"] = 10.50 * PizzaCount;
            }
            else if (PizzaType == 2)
            {
                ViewData["PizzaName"] = "Chicken and Pineapple";
                ViewData["total"] = 8.50 * PizzaCount;
            }
            else if (PizzaType == 3)
            {
                ViewData["PizzaName"] = "Pepperoni Feast";
                ViewData["total"] = 9 * PizzaCount;
            }
            else if (PizzaType == 4) 
            {
                ViewData["PizzaName"] = "Vegetarian";
                ViewData["total"] = 7 * PizzaCount;
            }
            return View();

        }

    }
}