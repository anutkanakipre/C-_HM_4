// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11, 82 -> 10, 9012 -> 12

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
   sum = sum + num % 10;
   num = num / 10;
}
Console.WriteLine($"Сумма цифр - {sum}");

 
// Console.WriteLine("Введите число  ");
// int N = Convert.ToInt32(Console.ReadLine());

// void Sum(int N)
// {
//    int sum = 0;
//    for (int i = N; i > 0; i++)
//    {
//       sum = sum + i;
//    }
//    Console.WriteLine(sum);
// }
// Console.WriteLine($"Сумма цифр - {Sum}");