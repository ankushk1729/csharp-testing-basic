namespace Alltests;

[TestFixture]
class DemeritPointsCalculatorTests {

    private DemeritPointsCalculator? _demeritPointsCalculator;    
    [SetUp]
    public void SetUp(){
        _demeritPointsCalculator = new DemeritPointsCalculator();
    }

    [Test]
    [TestCase(-1)]
    [TestCase(301)]
    public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowsArgumentOutOfRangeException(int speed){
        Assert.Throws<ArgumentOutOfRangeException>(() => _demeritPointsCalculator!.CalculateDemeritPoints(speed));
    }

    [Test]
    [TestCase(40)]
    [TestCase(55)]
    [TestCase(10)]
    public void CalculateDemeritPoints_SpeedIsGreaterThanZeroButUnderLimit_ReturnsZero(int speed){
        
        var result = _demeritPointsCalculator!.CalculateDemeritPoints(speed);
        Assert.That(result, Is.EqualTo(0));
    }


    [Test]
    [TestCase(70, 1)]
    [TestCase(75, 2)]
    [TestCase(83, 3)]
    [TestCase(90, 5)]
    public void CalculateDemeritPoints_SpeedIsAboveLimit_ReturnsDemeritPoints(int speed, int expectedResult){
        
        var result = _demeritPointsCalculator!.CalculateDemeritPoints(speed);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}