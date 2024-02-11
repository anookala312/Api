using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest;


[TestClass]
public class CalLibraryTests
{
    [TestMethod]
    public void TestAddPositiveNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Add(5.5m, 3.2m);
        Assert.AreEqual(8.7m, result, $"Expected: 8.7; Actual: {result}");
    }

    [TestMethod]
    public void TestAddNegativeNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Add(-2.0m, -3.5m);
        Assert.AreEqual(-5.5m, result, $"Expected: -5.5; Actual: {result}");
    }

    [TestMethod]
    public void TestAddZero()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Add(7.3m, 0m);
        Assert.AreEqual(7.3m, result, $"Expected: 7.3; Actual: {result}");
    }

    [TestMethod]
    public void TestAddDecimalPrecision()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Add(1.234m, 2.345m);
        Assert.AreEqual(3.579m, result, 0.001m, $"Expected: 3.579; Actual: {result}");
    }

    [TestMethod]
    public void TestAddWithNullValues()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal? x = null;
        decimal result = calLibrary.Add(x ?? 0m, 5.5m);
        Assert.AreEqual(5.5m, result, $"Expected: 5.5; Actual: {result}");
    }

    [TestMethod]
    public void TestSubtractPositiveNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Subtract(8.7m, 3.2m);
        Assert.AreEqual(5.5m, result, $"Expected: 5.5; Actual: {result}");
    }

    [TestMethod]
    public void TestSubtractNegativeNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Subtract(-2.0m, -3.5m);
        Assert.AreEqual(1.5m, result, $"Expected: 1.5; Actual: {result}");
    }

    [TestMethod]
    public void TestSubtractZero()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Subtract(7.3m, 0m);
        Assert.AreEqual(7.3m, result, $"Expected: 7.3; Actual: {result}");
    }

    [TestMethod]
    public void TestSubtractDecimalPrecision()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Subtract(3.579m, 2.345m);
        Assert.AreEqual(1.234m, result, 0.001m, $"Expected: 1.234; Actual: {result}");
    }

    [TestMethod]
    public void TestSubtractWithNullValues()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal? x = null;
        decimal result = calLibrary.Subtract(x ?? 0m, 5.5m);
        Assert.AreEqual(-5.5m, result, $"Expected: -5.5; Actual: {result}");
    }

    [TestMethod]
    public void TestMultiplyPositiveNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Multiply(2.5m, 3m);
        Assert.AreEqual(7.5m, result, $"Expected: 7.5; Actual: {result}");
    }

    [TestMethod]
    public void TestMultiplyNegativeNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Multiply(-2m, -3.5m);
        Assert.AreEqual(7m, result, $"Expected: 7; Actual: {result}");
    }

    [TestMethod]
    public void TestMultiplyZero()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Multiply(7.3m, 0m);
        Assert.AreEqual(0m, result, $"Expected: 0; Actual: {result}");
    }

    [TestMethod]
    public void TestMultiplyDecimalPrecision()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Multiply(1.234m, 2.345m);
        Assert.AreEqual(2.887m, result, 0.001m, $"Expected: 2.887; Actual: {result}");
    }

    [TestMethod]
    public void TestMultiplyWithNullValues()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal? x = null;
        decimal result = calLibrary.Multiply(x ?? 0m, 5.5m);
        Assert.AreEqual(0m, result, $"Expected: 0; Actual: {result}");
    }

    [TestMethod]
    public void TestDividePositiveNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Divide(8.7m, 2.5m);
        Assert.AreEqual(3.48m, result, $"Expected: 3.48; Actual: {result}");
    }

    [TestMethod]
    public void TestDivideNegativeNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Divide(-2.0m, -4m);
        Assert.AreEqual(0.5m, result, $"Expected: 0.5; Actual: {result}");
    }

    [TestMethod]
    public void TestDivideByZero()
    {
        CalLibrary calLibrary = new CalLibrary();
        Assert.ThrowsException<DivideByZeroException>(() => calLibrary.Divide(7.3m, 0m));
    }

    [TestMethod]
    public void TestDivideDecimalPrecision()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Divide(3.579m, 2.345m);
        Assert.AreEqual(1.529m, result, 0.001m, $"Expected: 1.529; Actual: {result}");
    }

    [TestMethod]
    public void TestDivideWithNullValues()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal? x = null;
        decimal result = calLibrary.Divide(x ?? 0m, 5.5m);
        Assert.AreEqual(0m, result, $"Expected: 0; Actual: {result}");
    }

    [TestMethod]
    public void TestModuloPositiveNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Modulo(8.7m, 3.2m);
        Assert.AreEqual(2.3m, result, $"Expected: 2.3; Actual: {result}");
    }

    [TestMethod]
    public void TestModuloNegativeNumbers()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Modulo(-5.0m, -3.5m);
        Assert.AreEqual(-1.5m, result, $"Expected: -1.5; Actual: {result}");
    }

    [TestMethod]
    public void TestModuloByZero()
    {
        CalLibrary calLibrary = new CalLibrary();
        Assert.ThrowsException<DivideByZeroException>(() => calLibrary.Modulo(7.3m, 0m));
    }

    [TestMethod]
    public void TestModuloDecimalPrecision()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal result = calLibrary.Modulo(3.579m, 2.345m);
        Assert.AreEqual(1.234m, result, 0.001m, $"Expected: 1.234; Actual: {result}");
    }

    [TestMethod]
    public void TestModuloWithNullValues()
    {
        CalLibrary calLibrary = new CalLibrary();
        decimal? x = null;
        decimal result = calLibrary.Modulo(x ?? 0m, 5.5m);
        Assert.AreEqual(0m, result, $"Expected: 0; Actual: {result}");
    }
}
