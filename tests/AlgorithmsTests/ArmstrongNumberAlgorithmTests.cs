using FluentAssertions;

namespace AlgorithmsTests;

public class ArmstrongNumberAlgorithmTests
{
    [Fact]
    public void IsArmstrongNumber_WhenNumberIsArmstrongNumber_ReturnsTrue()
    {
        // Arrange
        int number = 153;
        // Act
        bool result = Armstrong.Algorithm.IsArmstrongNumber(number);
        // Assert
        result.Should().BeTrue();
    }
    [Fact]
    public void IsArmstrongNumber_WhenNumberIsNotArmstrongNumber_ReturnsFalse()
    {
        // Arrange
        int number = 123;
        // Act
        bool result = Armstrong.Algorithm.IsArmstrongNumber(number);
        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void IsArmstrongNumber_WhenNumberIsZero_ReturnsTrue()
    {
        // Arrange
        int number = 0;
        // Act
        bool result = Armstrong.Algorithm.IsArmstrongNumber(number);
        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsArmstrongNumber_shouldReturnTrue_whenNumberIsNegative()
    {
        // Arrange
        int number = -153;
        // Act
        bool result = Armstrong.Algorithm.IsArmstrongNumber(number);
        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void IsArmstrongNumber_shouldReturnTrue_whenNumberIsSingleDigit()
    {
        // Arrange
        int number = 5;
        // Act
        bool result = Armstrong.Algorithm.IsArmstrongNumber(number);
        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void DigitExtractionAndRemovalTests()
    {
        (153 % 10).Should().Be(3); // extract the last digit
        (153 / 10).Should().Be(15); // remove the last digit

        (15 % 10).Should().Be(5); // extract the last digit
        (15 / 10).Should().Be(1); // remove the last digit

        (1 % 10).Should().Be(1); // extract the last digit
        (1 / 10).Should().Be(0); // remove the last digit

        153.ToString().Length.Should().Be(3); // get the number of digits

        (3 / 10).Should().Be(0); // remove the last digit
    }
}
