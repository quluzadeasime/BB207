namespace MethodTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5,4,10};
            ElementTotal(array);
        }
        
        public static void ElementTotal(int[] array)
        {
            int total = 1;
            for (int i = 0; i < array.Length; i++)
            {
                total *= array[i];
            }
            Console.WriteLine(total);
        }
    }
}
