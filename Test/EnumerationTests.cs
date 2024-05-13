using VestaboardPackage;

namespace Test;

public class EnumerationTests
{
    [Test]
    [TestCase("@", 38)]
    public void TestSymbols(string symbol, int id)
    {
        var actual = Enumeration.GetIdFromSymbol(symbol);
        Assert.AreEqual(id, actual);
    }

    [Test]
    [TestCase("green", 66)]
    public void TestColors(string color, int id)
    {
        var actual = Enumeration.GetIdFromValue<Color>(color);
        Assert.AreEqual(id, actual);
    }

    [Test]
    [TestCase("A", 1)]
    [TestCase("B", 2)]
    [TestCase("C", 3)]
    [TestCase("D", 4)]
    [TestCase("E", 5)]
    [TestCase("F", 6)]
    [TestCase("G", 7)]
    [TestCase("H", 8)]
    [TestCase("I", 9)]
    [TestCase("J", 10)]
    [TestCase("K", 11)]
    [TestCase("L", 12)]
    [TestCase("M", 13)]
    [TestCase("N", 14)]
    [TestCase("O", 15)]
    [TestCase("P", 16)]
    [TestCase("Q", 17)]
    [TestCase("R", 18)]
    [TestCase("S", 19)]
    [TestCase("T", 20)]
    [TestCase("U", 21)]
    [TestCase("V", 22)]
    [TestCase("W", 23)]
    [TestCase("X", 24)]
    [TestCase("Y", 25)]
    [TestCase("Z", 26)]
    public void TestLetters(string letter, int id)
    {
        var actual = Enumeration.GetIdFromValue<Letter>(letter);
        Assert.AreEqual(id, actual);
    }
}