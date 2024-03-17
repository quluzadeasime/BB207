namespace MethodTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));

        }
        public static string Fibonacci(int number)
        {
            string fibonacciNumbers = "";
            int a = 0;
            fibonacciNumbers += a + " ";
            int b = 1;
            while (b <= number)
            {
                fibonacciNumbers += b + " ";
                int c = a;
                a = b;
                b = c + b;
            }
            return fibonacciNumbers;

        }
    }
}
