namespace Src
{
    public class MathUtils {
        public int Max(int a, int b){
            return (a > b) ? a : b;
        }

        public List<int> GetEvenNumbers(int limit){
            List<int> res = new List<int>();
            for(int i = 1;i<=limit;i++){
                if(i % 2 == 0) res.Add(i);
            }
            return res;
        }
    }
}