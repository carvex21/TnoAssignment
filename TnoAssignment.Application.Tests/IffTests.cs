using Shouldly;

namespace TnoAssignment.Application.Tests;

public class IffTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsHostile_ShouldReturnFalse_WhenZeroesAreMoreThanOnes()
    {
        // Assign
        var unit = "0101010000101000010";

        // Act
        var isHostile = Iff.IsHostile(unit);

        // Assert
        isHostile.ShouldBeFalse();
    }

    [Test]
    public void IsHostile_ShouldReturnTrue_WhenOnesAreMoreThanZeroes()
    {
        // Assign
        var unit = "0101010111111111111010";

        // Act
        var isHostile = Iff.IsHostile(unit);

        // Assert
        isHostile.ShouldBeTrue();
    }

    [Test]
    public void IsHostile_ShouldThrow_WhenUnitStringIsEmpty()
    {
        // Assign
        var unit = "";

        // Act
        // Assert
        Should.Throw<Exception>(() => Iff.IsHostile(unit));
    }
}