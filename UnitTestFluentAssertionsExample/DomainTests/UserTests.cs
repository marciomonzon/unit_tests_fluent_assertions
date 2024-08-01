using Domain.Entities;
using FluentAssertions;
using FluentAssertions.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTests
{
    public class UserTests
    {
        [Theory]
        [InlineData("John Cast")]
        [InlineData("Alex Mountain")]
        public void TestFullName(string fullName)
        {
            // Arrange
            var user = new User(fullName);

            // Act
            var actual = user.FullName;

            // Assert
            Assert.Equal(fullName, actual);
        }

        [Theory]
        [InlineData("Cast", "John Cast")]
        [InlineData("Mountain", "Alex Mountain")]
        public void TestLastName(string lastName, string fullName)
        {
            // Arrange
            var user = new User(fullName);

            // Act
            var actual = user.LastName;

            // Assert
            Assert.Equal(lastName, actual);
        }

        [Theory]
        [InlineData("John", "Mark Two", "John Mark Two")]
        public void TestingEdgeCaseNames(string firstName, string lastName, string fullName)
        {
            // Arrange
            var user = new User(fullName);

            using var _ = new AssertionScope();

            user.FirstName.Should().Be(firstName);

            user.LastName.Should()
                .StartWith(lastName.Substring(0, 4)); // Mark
        }
    }
}
