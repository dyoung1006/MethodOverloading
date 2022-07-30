
namespace MethodOverloading
{ 
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var _sum = num1 + num2;

            if (isTrue && _sum == 1)
            {
                return $"{_sum} dollar";
            }
            else if (isTrue && _sum > 1)
            {
                return $"{_sum} dollars";
            }
            else
            {
                return $"{num1 + num2}";
            }
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            decimal c = 3.2m;
            decimal d = 8.3m;

            var r1 = Add(a, b);
            var r2 = Add(c, d);
            var r3 = Add(a, b, false);
       }
    }
}
