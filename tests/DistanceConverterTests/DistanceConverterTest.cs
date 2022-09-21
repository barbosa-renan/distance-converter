using DistanceConverterAPI;

namespace DistanceConverterTests
{
    public class DistanceConverterTest
    {
        [Fact]
        public void TryConvertToKilometer_MustConvertWithSuccess()
        {
            // Arrange & Act
            var result = DistanceConverter.ToKilometers(200);

            // Assert
            Assert.Equal(321.9, result);
        }

        [Fact]
        public void TryConvertToMiles_MustConvertWithSuccess()
        {
            // Arrange & Act
            var result = DistanceConverter.ToMiles(321.9);

            // Assert
            Assert.Equal(200, result);
        }
    }
}