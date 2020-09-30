using System;
using Challenge2Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge2UnitTest
{
    [TestClass]
    public class ClaimsTest
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
            Claims testClaims = new Claims(firstName, lastName, id, myBirthday);
            // Assert
            Assert.AreEqual(LastName, testUser.LastName);

        }
    }
}
