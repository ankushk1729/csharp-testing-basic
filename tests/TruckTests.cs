namespace AllTests;

class TruckTests
{
    public Truck? _truck;
    [SetUp]
    public void SetUp(){
        _truck = new Truck();
    }

    [Test]
    public void Start_WhenNoPower_ReturnsError(){
        var result = _truck!.Start(new FakeEngine());

        Assert.That(result, Does.Contain("error").IgnoreCase);
    }
}