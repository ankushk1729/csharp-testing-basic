namespace AllTests;
using Moq;

class TruckTests
{
    private Truck? _truck;
    private Mock<IEngine>? _engine;

    [SetUp]
    public void SetUp(){
        _engine = new Mock<IEngine>();
        _truck = new Truck(_engine.Object);
    }

    [Test]
    public void Start_WhenNoPower_ReturnsError(){

        _engine!.Setup(eng => eng.GetPower()).Returns("");
        var result = _truck!.Start();

        // Verify that a method was called
        _engine.Verify(e => e.GetPower());

        Assert.That(result, Does.Contain("error").IgnoreCase);
    }
}