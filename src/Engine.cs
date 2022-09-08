namespace Src
{
    public interface IEngine {
        string GetPower();
    }
    public class Engine : IEngine
    {
        private int _rpm;
        private int numCylinders;

        public string GetPower(){
            int power = _rpm * numCylinders;
            return power.ToString();
        }
    }
}