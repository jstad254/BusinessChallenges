using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Repo
{
    public class Menu
    {
        public Dictionary<int, string> MealDictionary { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Menu> Ingredients { get; set; }
        public decimal Price { get; set; }

        public Menu()
        {

        }
        public Menu(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
