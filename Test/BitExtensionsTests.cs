using VestaboardPackage;

namespace Test;

public class BitExtensionsTests
{
    [Test]
    [TestCase("red", 63)]
    [TestCase("orange", 64)]
    [TestCase("yellow", 65)]
    [TestCase("green", 66)]
    [TestCase("blue", 67)]
    [TestCase("purple", 68)]
    [TestCase("white", 69)]
    [TestCase("black", 70)]
    [TestCase("filled", 71)]
    [TestCase ("invalid", 0)]
    public void GetColorIDTest(string color, int expected)
    {
        var colorID = BitExtensions.GetColorID(color);
        
        Assert.AreEqual(expected, colorID);
    }
}