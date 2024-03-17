namespace MethodTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Fibonacci(n);
            
        }
        public static void Fibonacci(int number)
        {
            int a = 0;
            Console.Write(a+" ");
            int b = 1;
            while (b <= number)
            {
                Console.Write(b+" ");
                int c = a;
                a = b;
                b = c + b;
            }
            Console.WriteLine();

        }
    }
}
