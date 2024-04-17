namespace Geometry.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry.Library;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double expectedArea = 6; // Area of a triangle with sides 3, 4, and 5 is 6

        // Act
        double actualArea = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea, "Area calculation is incorrect.");
    }

    [TestMethod]
    public void CalculatePerimeter_ValidTriangle_ReturnsCorrectPerimeter()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double expectedPerimeter = 12; // Perimeter of a triangle with sides 3, 4, and 5 is 12

        // Act
        double actualPerimeter = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(expectedPerimeter, actualPerimeter, "Perimeter calculation is incorrect.");
    }

    [TestMethod]
    public void CalculateArea_NegativeSide_ThrowsException()
    {
        // Arrange
        double sideA = -3;
        double sideB = 4;
        double sideC = 5;

        // Act & Assert
        Assert.ThrowsException<System.ArgumentException>(() => new Triangle(sideA, sideB, sideC), "Negative side length should throw ArgumentException.");
    }
}
