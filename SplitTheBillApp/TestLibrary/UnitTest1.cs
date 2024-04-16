using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitClassLibrary.TestLibrary;
using UtilityLibraries;
namespace SplitClassLibrary;

namespace TestLibrary;

[TestClass]
public class splitTest
{
    [TestMethod]
    public void Test_splitamount_EqualSplit()
    {
        // Arrange
        decimal price = 10.0m;
        int patrons = 5;
        decimal expectedSplit = 2.0m;

        // Act
        decimal actualSplit = splitamount(price, patrons);

        // Assert
        Assert.AreEqual(expectedSplit, actualSplit);
    }

    [TestMethod]
    public void Test_splitamount_Rounding()
    {
        // Arrange
        decimal price = 10.0m;
        int patrons = 3;
        decimal expectedSplit = 3.33m;

        // Act
        decimal actualSplit = splitamount(price, patrons);

        // Assert
        Assert.AreEqual(expectedSplit, actualSplit, 0.01m); // Allowing for a small tolerance due to rounding
    }

    [TestMethod]
    public void Test_splitamount_ZeroPatrons()
    {
        // Arrange
        decimal price = 10.0m;
        int patrons = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => splitamount(price, patrons));
    }

    public void TipCalculator_WithValidInputs_ShouldReturnCorrectValues()
    {
        // Arrange
        Dictionary<string, decimal> individualAmt = new Dictionary<string, decimal>
        {
            {"Alice", 20.0m},
            {"Bob", 30.0m},
            {"Charlie", 40.0m}
        };
        float tipPercent = 15.0f;

        // Act
        Dictionary<string, decimal> result = tipCalculator(individualAmt, tipPercent);

        // Assert
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual(2.25m, result["Alice"]);
        Assert.AreEqual(3.375m, result["Bob"]);
        Assert.AreEqual(4.5m, result["Charlie"]);
    }

    [Test]
    public void TipCalculator_WithEmptyDictionary_ShouldReturnEmptyDictionary()
    {
        // Arrange
        Dictionary<string, decimal> individualAmt = new Dictionary<string, decimal>();
        float tipPercent = 10.0f;

        // Act
        Dictionary<string, decimal> result = tipCalculator(individualAmt, tipPercent);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void TipCalculator_WithZeroTipPercentage_ShouldReturnZeroTip()
    {
        // Arrange
        Dictionary<string, decimal> individualAmt = new Dictionary<string, decimal>
        {
            {"Alice", 25.0m},
            {"Bob", 35.0m}
        };
        float tipPercent = 0.0f;

        // Act
        Dictionary<string, decimal> result = tipCalculator(individualAmt, tipPercent);

        // Assert
        Assert.AreEqual(2, result.Count);
        Assert.AreEqual(0.0m, result["Alice"]);
        Assert.AreEqual(0.0m, result["Bob"]);
    }

}