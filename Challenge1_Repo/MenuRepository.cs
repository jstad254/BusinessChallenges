using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_KomodoCafeRepo
{
    public class MenuRepository
    {
        Menu menu = new Menu();
        private List<Menu> _listOfMenus = new List<Menu>();
        // Create... to create menu items
        public void AddToMenu(Menu menuItem)
        {
            _listOfMenus.Add(menuItem);
        }
        // Read... to display menu items
        public List<Menu> DisplayMenu()
        {
            return _listOfMenus;
        }
        // Update... not required
        // Delete... to delete menu items
        public bool RemoveFromMenu(string number)
        {
            Menu menuItem = GetByNumber(number);
            if(menuItem == null)
            {
                return false;
            }
            int initialCount = _listOfMenus.Count;
            _listOfMenus.Remove(menuItem);
            if(initialCount > _listOfMenus.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Helper to use the Menu Number to get menu item to delete
        public Menu GetByNumber(string number)
            {
            foreach (Menu menuItem in _listOfMenus)
            {
                if (menuItem.Number == number)
                {
                    return menuItem;
                }
            }
            return null;
        }
    }
}
