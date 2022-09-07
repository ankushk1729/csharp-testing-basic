namespace Src
{
    public class Choice
    {
        public Vehice CarOrBike(string input) {
            if(input.ToLower() == "car") return new Car();
            else if(input.ToLower() == "bike") return new Bike();
            throw new InvalidDataException("Invalid argument, expect car or bike");
        }
    }

    public class Vehice {}

    public class Car : Vehice {}

    public class Bike : Vehice {}

}