using System;
using Challenge3Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge3UnitTest
{
    [TestClass]
    public class BadgeTest
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
            Badge testBadge = new Badges(firstName, lastName, id, myBirthday);
            // Assert
            Assert.AreEqual(LastName, testUser.LastName);

        }
    }
}
