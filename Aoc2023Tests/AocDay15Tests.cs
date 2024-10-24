namespace Aoc2023Tests;
using Aoc2023.Solutions;

[TestFixture]
public class AocDay15Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("rn=1", 30)]
    [TestCase("cm-", 253)]
    [TestCase("qp=3", 97)]
    [TestCase("cm=2", 47)]
    [TestCase("qp-", 14)]
    [TestCase("pc=4", 180)]
    [TestCase("ot=9", 9)]
    [TestCase("ab=5", 197)]
    [TestCase("pc-", 48)]
    [TestCase("pc=6", 214)]
    [TestCase("ot=7", 231)]
    public void CalculateCodeValueShouldReturnWhen(string code, int expected)
    {
        var actual = AocDay15.CalculateCodeValue(code);

        Assert.That(expected, Is.EqualTo(actual));
    }

    /*[Test]
    public void Part01ShouldPass()
    {
        var result = AocDay01.Part01();

        Assert.That(result, Is.EqualTo(55386));
    }

    [Test]
    public void Part02ShouldPass()
    {
        var result = AocDay01.Part02();

        Assert.That(result, Is.EqualTo(54824));
    }*/
}
