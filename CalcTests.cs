namespace ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CalcTests
{
    [TestMethod]
    public void ShouldAdd_GivenTwoInts()
    {
        var a = 1;
        var b = 1;
        var result = Calc.Add(a, b);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ShouldSubstract_GivenTwoInts()
    {
        var a = 1;
        var b = 1;
        var result = Calc.Substract(a, b);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ShouldMultiply_GivenTwoInts()
    {
        var a = 1;
        var b = 1;
        var result = Calc.Multiply(a, b);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ShouldDivide_GivenTwoInts()
    {
        var a = 1;
        var b = 1;
        var result = Calc.Divide(a, b);
        Assert.AreEqual(1, result);
    }
}