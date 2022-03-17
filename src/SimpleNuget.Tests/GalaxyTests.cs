using System;

using Xunit;

namespace SimpleNuget.Tests
{
    public class GalaxyTests
    {
        private readonly Galaxy _galaxy;

        public GalaxyTests()
        {
            _galaxy = new Galaxy();
        }

        [Fact]
        public void AddStar_WithoutName_Should_ThrowArgumentException()
        {
            //Act
            var error = Assert.ThrowsAny<ArgumentException>(() => _galaxy.AddStar(string.Empty, 0));

            //Assert
            Assert.Equal("name", error.ParamName);
            Assert.Equal("Value cannot be null or empty. (Parameter 'name')", error.Message);
        }

        [Fact]
        public void AddStar_WithoutDistance_Should_ThrowArgumentException()
        {
            //Act
            var error = Assert.ThrowsAny<ArgumentException>(() => _galaxy.AddStar("StringEmpty", 0));

            //Assert
            Assert.Equal("distance", error.Message);
        }

        [Fact]
        public void AddStar_ShouldSaveData()
        {
            //Act
            _galaxy.AddStar("StringEmpty", 1000);

            //Assert
            Assert.Equal("StringEmpty", _galaxy.Name);
            Assert.Equal(1000, _galaxy.Distance);
        }
    }
}
