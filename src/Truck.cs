namespace Src
{
    public class Truck
    {
        private string? _power;
        private IEngine _engine;
        public Truck(IEngine engine){
            _engine = engine;
        }
        public string Start(){
            _power = _engine.GetPower();

            if(_power == "") return "Error, can't start without power";
            
            return _power + "hp";
        }
    }
}