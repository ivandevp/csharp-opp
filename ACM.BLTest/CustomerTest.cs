using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ivan";
            customer.LastName = "Medina";

            string expected = "Medina, Ivan";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ivan";

            string expected = "Ivan";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Ivan";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "Annie";
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            c3.FirstName = "Stephannie";
            Customer.InstanceCount += 1;

            int expected = 3;

            // Act
            int actual = Customer.InstanceCount;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Medina";
            customer.EmailAddress = "medinadiazivan@gmail.com";

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer();
            customer.EmailAddress = "medinadiazivan@gmail.com";

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
