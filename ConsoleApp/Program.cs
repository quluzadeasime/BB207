//#region  
//int n = 1237;
//int hasil = 1;
//int qaliq = 0;

//while (n !> 0)
//{
//    qaliq = n % 10;
//    hasil *= qaliq;
//    n = n / 10;
//}
//Console.WriteLine(hasil);
//#endregion

//#region
//int n = 60;
//int control = 0;

//for(int i = 2; i < n; i++)
//{
//    if (n % i == 0)
//        control++;
//} 
//if (control != 0)
//    Console.WriteLine("SADE DEYIL");
//else
//    Console.WriteLine("SADEDIR");
//#endregion


//#region
//int faktorial = 1;
//n = 6;
//for (int i = 2; i <= n; i++)
//{
//    faktorial *= i;
//}
//Console.WriteLine(faktorial);
//#endregion

int n = 122;
int firstNum = n;
int secondNum = 0;
int qaliq = 0;

while (n > 0)
{
    qaliq = n % 10;
    secondNum = secondNum * 10 + qaliq;
    n /= 10;
}
if (firstNum == secondNum)
{
    Console.WriteLine("polindromdur");
}
else
{
    Console.WriteLine("polindrom deyil");
}
