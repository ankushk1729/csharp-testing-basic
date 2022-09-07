namespace AllTests;

[TestFixture]
public class ChoiceTests
{
    private Choice? _choice;

    [SetUp]
    public void SetUp(){
        _choice = new Choice();
    }

    [Test]
    public void CarOrBike_InputIsCar_ReturnsCar(){
        var result = _choice!.CarOrBike("car");

        Assert.That(result, Is.InstanceOf<Car>());
    }
    
    [Test]
    public void CarOrBike_InputIsBike_ReturnsBike(){
        var result = _choice!.CarOrBike("bike");

        Assert.That(result, Is.InstanceOf<Bike>());
    }

    [Test]
    public void CarOrBike_InputIsWrong_ThrowsException(){
        Assert.Throws<InvalidDataException>(() => _choice!.CarOrBike("something else"));
    }
}