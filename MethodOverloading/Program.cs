namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck  && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck  && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(5, 50, true);

            Console.WriteLine($"int add: {answer}");
            Console.WriteLine($"decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);


           }
    }
}
