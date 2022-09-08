namespace Src
{
    public class Truck
    {
        private string? _power;

        public string Start(IEngine engine){
            _power = engine.GetPower();

            if(_power == "") return "Error, can't start without power";
            
            return _power + "hp";
        }
    }
}