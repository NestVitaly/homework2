//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите любое трёхзначное число ");
try
{ 
    int num = Convert.ToInt32 (Console.ReadLine());
    int num1 = num % 100;
    int num2 = num1 / 10;
    Console.WriteLine(num2);
}
catch 
{
    Console.WriteLine("Введены некорректные данные");
}