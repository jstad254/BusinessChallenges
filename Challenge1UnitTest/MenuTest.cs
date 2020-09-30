using System;
using Challenge1_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace Challenge1UnitTest
{
    [TestClass]
    public class MenuTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange      Set up the necessary pieces to run code
            string firstName = "Nick";
            string lastName = "Perry";
            int id = 1;
            DateTime myBirthday = new DateTime(2000, 8, 29);

            // Act          Run code we want to make sure works
            Menu testMenu = new Menu(firstName, lastName, id, myBirthday);
            // Assert
            Assert.AreEqual(LastName, testUser.LastName);
        }
    }
}
