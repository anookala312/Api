using ClassLibrary.Classes;

namespace TestLibrary;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestSquareArea()
    {
    // Arrange
    var square = new Square(5);

    // Act
    var result = square.CalculateArea();

    // Assert
    Assert.AreEqual(25, result);
    }
    [TestMethod]
    public void TestRectangleArea()
    {
    // Arrange
    var rectangle = new Rectangle(5,4);

    // Act
    var result = rectangle.CalculateArea();

    // Assert
    Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void TestTriangleArea()
    {
    // Arrange
    var triangle = new Triangle(8,6);

    // Act
    var result = triangle.CalculateArea();

    // Assert
    Assert.AreEqual(15, result);
    }
    [TestMethod]
    public void TestSquarePerimeter()
    {
    // Arrange
    var square = new Square(5);

    // Act
    var result = square.CalculatePerimeter();

    // Assert
    Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void TestRectanglePerimeter()
    {

    // Arrange
    var rectangle = new Rectangle(5,4);

    // Act
    var result = rectangle.CalculatePerimeter();

    // Assert
    Assert.AreEqual(18, result);
    }
    [TestMethod]
    public void TestTrianglePerimeter()
    {
    // Arrange
    var triangle = new Triangle(8,6);

    // Act
    var result = triangle.CalculateArea();

    // Assert
    Assert.AreEqual(24, result);
    }
    
}