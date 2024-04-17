namespace Geometry.Tests;
using Geometry.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void CalculateArea_WithValidSideLength_ReturnsCorrectArea()
    {
        // Arrange
        double sideLength = 5;
        Square square = new Square(sideLength);

        // Act
        double area = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, area);
    }

    [TestMethod]
    public void CalculatePerimeter_WithValidSideLength_ReturnsCorrectPerimeter()
    {
        // Arrange
        double sideLength = 5;
        Square square = new Square(sideLength);

        // Act
        double perimeter = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, perimeter);
    }

    [TestMethod]
    public void Square_Constructor_NegativeSideLength_ThrowsException()
    {
        // Arrange
        double sideLength = -5;

        // Act & Assert
        Assert.ThrowsException<System.ArgumentException>(() => new Square(sideLength), "Negative side length should throw ArgumentException.");
    }
}
