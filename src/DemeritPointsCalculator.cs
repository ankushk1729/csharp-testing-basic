namespace Src
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 65;
        public int CalculateDemeritPoints(int speed){
            if(speed < 0 || speed > 300)
                throw new ArgumentOutOfRangeException();

            if(speed <= SpeedLimit) return 0;


            const int kmPerDemeritPoint = 5;

            var demeritPoints = (speed - SpeedLimit)/kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}