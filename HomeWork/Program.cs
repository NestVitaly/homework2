//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите любое трёхзначное число ");
// try
// { 
//     int num = Convert.ToInt32 (Console.ReadLine());
//     int num1 = num % 100;
//     int num2 = num1 / 10;
//     Console.WriteLine(num2);
// }
// catch 
// {
//     Console.WriteLine("Введены некорректные данные");
// }

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
void numbers(int num)
{
    if (num >= 100)
    {
        Console.WriteLine("Третья цифра "+num.ToString()[2]);
    }
        else if (num <= 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
    numbers(num);