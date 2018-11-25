using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uni.PizzaMVC.Models;

namespace Uni.PizzaMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Select your damned pizza!";

            return View(new PizzaSelectionViewModel() { Pizzas = Statics.Pizzas });
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public static class Statics
    {
        public static List<PizzaViewModel> Pizzas = new List<PizzaViewModel>()
        {
            new PizzaViewModel
            {
                Name = "Дотерская",
                Price = 999.0f,
                Ingredients =
                {
                    "Твои тиммейты",
                    "Варды",
                    "Кура",
                    "Твой ММР"
                }
            },
            new PizzaViewModel
            {
                Name = "Московская",
                Price = 499.0f,
                Ingredients =
                {
                    "Курица",
                    "Тесто",
                    "Кремль"
                }
            },
            new PizzaViewModel
            {
                Name = "Шикарная",
                Price = 9999.50f,
                Ingredients =
                {
                    "Шаурма",
                    "Пельмени",
                    "Шашлык",
                    "Сын маминой подруги"
                }
            }
        };
    }
}