//#region 
//string[] array1 = { "Yusif", "Resul", "Enver" };

//Console.Write("Enter index: ");
//int index = Convert.ToByte(Console.ReadLine());

//if (index < array1.Length)
//{
//    string name = array1[index];

//    for (int i = name.Length - 1; i >= 0; i--)
//    {
//        Console.Write(name[i]);
//    }
//}
//else
//{
//    Console.WriteLine("Duzgun deyer daxil edin");
//}
//#endregion


//#region
// int[] numbers = { 23, 43, 53, 27, 3, 6 };
// int minNumber = numbers[0]; 

// for(int i = 1; i<numbers.Length; i++)
// {
//     if (numbers[i] < minNumber)
//     {
//         minNumber = numbers[i];
//     }
// }
// Console.WriteLine(minNumber);
//#endregion

int[] numbers = { 3, -4, -2, 4, 3, 9 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        numbers[i] = -numbers[i];

    }
}
for (int j = numbers.Length - 1; j >= 0; j--)
{
    Console.WriteLine(numbers[j]);
}
