using System;
using System.Dynamic;
using Challenge1_KomodoCafeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace Challenge1UnitTest
{
    [TestClass]
    public class MenuTest
    {
        private MenuRepository _menuRepository = new MenuRepository();

        [TestMethod]
        public void TestViewMethod()
        {
            // Arrange      Set up the necessary pieces to run code

            // Act          Run code we want to make sure works

            // Assert

        }
        public void TestAddMethod()
        {
            // Arrange      Set up the necessary pieces to run code
            string number = "5";
            string name = "Daily Special";
            string description = "Fried Chicken, Mashed Potatoes, One side, and Drink.";
            decimal price = 6.75;
            List<string> ingredients = new List<string>();

            // Act          Run code we want to make sure works
            Menu testMenu = new Menu(number, name, description, price);
            // Assert
            Assert.AreEqual(Number, testUser.Number);
            Assert.AreEqual(Name, testUser.Name);
            Assert.AreEqual(Description, testUser.Description);
            Assert.AreEqual(Price, testUser.Price);
        }
        public void TestDeleteMethod()
        { 
            // Arrange      Set up the necessary pieces to run code

            // Act          Run code we want to make sure works

            // Assert

        }
    }
}
