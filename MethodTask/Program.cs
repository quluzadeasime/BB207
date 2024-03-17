namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "salam", "code", "print","string" };
            string[] array2 = { "write", "code", "string" };
            SameElement(array1, array2);

            
        }

        public static void SameElement(string[] array1,string[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {

                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine(array1[i]);
                        break;
                    }
                }
            }
            
        }
    }
}
