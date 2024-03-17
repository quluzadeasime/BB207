namespace MethodTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Asime", "Fatime", "Aytac", "Gulcohre" };

            FirstLetter(array);
        }
        public static void FirstLetter(string[] word)
        {
            string firstLetter = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i][0] == 'A')
                {
                    Console.WriteLine(word[i]);
                }
            }

        }
    }
}

