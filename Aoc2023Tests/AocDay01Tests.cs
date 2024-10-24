namespace Aoc2023Tests;
using Aoc2023.Solutions;

public class AocDay01Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
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
    }
}
