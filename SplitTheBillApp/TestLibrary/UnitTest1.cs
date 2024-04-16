using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SplitClassLibrary
{
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
            decimal actualSplit = Split.splitamount(price, patrons);

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
            decimal actualSplit = Split.splitamount(price, patrons);

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
            Assert.ThrowsException<DivideByZeroException>(() => Split.splitamount(price, patrons));
        }

        [TestMethod]
        public void Test_TipCalculator_WithValidInputs_ShouldReturnCorrectValues()
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
            Dictionary<string, decimal> result = Split.tipCalculator(individualAmt, tipPercent);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(3.0m, result["Alice"], 0.01m);
            Assert.AreEqual(4.5m, result["Bob"], 0.01m);
            Assert.AreEqual(6.0m, result["Charlie"], 0.01m);
        }

        [TestMethod]
        public void Test_TipCalculator_WithEmptyDictionary_ShouldReturnEmptyDictionary()
        {
            // Arrange
            Dictionary<string, decimal> individualAmt = new Dictionary<string, decimal>();
            float tipPercent = 10.0f;

            // Act
            Dictionary<string, decimal> result = Split.tipCalculator(individualAmt, tipPercent);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Test_TipCalculator_WithZeroTipPercentage_ShouldReturnZeroTip()
        {
            // Arrange
            Dictionary<string, decimal> individualAmt = new Dictionary<string, decimal>
            {
                {"Alice", 25.0m},
                {"Bob", 35.0m}
            };
            float tipPercent = 0.0f;

            // Act
            Dictionary<string, decimal> result = Split.tipCalculator(individualAmt, tipPercent);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Test_indTipAmt_WithValidInputs_ReturnsCorrectTipPerPerson()
        {
            // Arrange
            decimal price = 100.00m;
            int patrons = 5;
            decimal tipPercentage = 15;

            // Act
            decimal tipPerPerson = Split.indTipAmt(price, patrons, tipPercentage);

            // Assert
            Assert.AreEqual(3.00m, tipPerPerson); // Assuming tip is calculated correctly
        }

        [TestMethod]
        public void Test_indTipAmt_PriceIsZero_ReturnsZeroTipPerPerson()
        {
            // Arrange
            decimal price = 0m;
            int patrons = 5;
            decimal tipPercentage = 15;

            // Act
            decimal tipPerPerson = Split.indTipAmt(price, patrons, tipPercentage);

            // Assert
            Assert.AreEqual(0m, tipPerPerson);
        }

        [TestMethod]
        public void Test_indTipAmt_NegativeTipPercentage_ThrowsArgumentException()
        {
            // Arrange
            decimal price = 100.00m;
            int patrons = 5;
            decimal tipPercentage = -5; // Negative tip percentage

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => Split.indTipAmt(price, patrons, tipPercentage));
        }
    }
}
