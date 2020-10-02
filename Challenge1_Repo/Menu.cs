using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_KomodoCafeRepo
{
    public class Menu
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Price { get; set; }

        public Menu()
        {

        }
        public Menu(string number)
        {
            Number = number;
        }
        public Menu(string number, string name, string description, decimal price, List<string> ingredients) : this(number)
        {
            Name = name;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }
    }
}
