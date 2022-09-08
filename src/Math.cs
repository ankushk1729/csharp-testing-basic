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

        public string FizzBuzz(int num){
            if(num % 3 == 0 && num % 5 == 0){
                return "FizzBuzz";
            }
            if(num % 3 == 0){
                return "Fizz";
            }
            if(num % 5 == 0){
                return "Buzz";
            }

            return num.ToString();
        }
    }
}