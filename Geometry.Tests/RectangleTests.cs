namespace Geometry.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry.Library;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void CalculateArea_Returns_CorrectArea()
    {
        // Arrange
        double length = 5;
        double width = 3;
        double expectedArea = 15;

        // Act
        Rectangle rectangle = new Rectangle(length, width);
        double actualArea = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void CalculatePerimeter_Returns_CorrectPerimeter()
    {
        // Arrange
        double length = 5;
        double width = 3;
        double expectedPerimeter = 16;

        // Act
        Rectangle rectangle = new Rectangle(length, width);
        double actualPerimeter = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(expectedPerimeter, actualPerimeter);
    }

    [TestMethod]
    public void CalculatePerimeter_Returns_CorrectPerimeter_When_LengthAndWidthAreEqual()
    {
        // Arrange
        double length = 4;
        double width = 4;
        double expectedPerimeter = 16;

        // Act
        Rectangle rectangle = new Rectangle(length, width);
        double actualPerimeter = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(expectedPerimeter, actualPerimeter);
    }
}
