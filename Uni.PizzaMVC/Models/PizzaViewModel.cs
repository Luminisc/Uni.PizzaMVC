using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uni.PizzaMVC.Models
{
    public class PizzaViewModel
    {
        public string Name;
        public float Price;
        public List<string> Ingredients = new List<string>();
    }
}