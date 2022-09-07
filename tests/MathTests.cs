namespace AllTests;

[TestFixture]
public class MathTests
{
    private MathUtils? _math;

    [SetUp]
    public void SetUp(){
        _math = new MathUtils();
    }

    [Test]
    [TestCase (1, 2, 2)]
    [TestCase (2, 1, 2)]
    [TestCase (1, 1, 1)]
    public void Max_WhenCalled_ReturnsGreaterArgument(int a, int b, int expectedResult)
    {
        int result = _math!.Max(a, b);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void GetEvenNumbers_LimitIsGreaterThanZero_ReturnsEvenNumbersUptoLimit(){
        List<int> result = _math!.GetEvenNumbers(7);
        
        // Now there are multiple ways to write our assertions here

        // Assert.That(result, Is.Not.Empty);

        // Assert.That(result.Count(), Is.EqualTo(3));
        // Assert.That(result, Does.Contain(2));
        // Assert.That(result, Does.Contain(4));
        // Assert.That(result, Does.Contain(6));

        Assert.That(result, Is.EquivalentTo(new List<int>(){2, 4, 6}));
    }

    [Test]
    public void GetEvenNumbers_LimitIsLessThanOrEqualToZero_ReturnsEmptyList(){
        List<int> result = _math!.GetEvenNumbers(0);
        
        // Now there are multiple ways to write our assertions here

        Assert.That(result, Is.Empty);

        // Assert.That(result.Count(), Is.EqualTo(0));

        // Assert.That(result, Does.Not.Contain(2));

        // Assert.That(result, Is.EquivalentTo(new List<int>()));
    }
    
}