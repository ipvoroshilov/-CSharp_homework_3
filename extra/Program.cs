// задача необязательная
// ### Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
// Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.
// В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем, что сумма этих чисел равна нулю и выводим сумму их квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.﻿
// На входе:
// 1
// -3
// 5
// -6
// -10
// 13
// 4
// -8
// На выходе:
// 340


double function()
{
    double sum = 0;
    double squareSum = 0;

    Console.WriteLine("Input numbers");
    double number = Convert.ToInt32(Console.ReadLine());
    sum = sum + number;
    squareSum = squareSum + Math.Pow(number,2);

    while (sum != 0)
    {
        number = Convert.ToInt32(Console.ReadLine());
        sum = sum + number;
        squareSum = squareSum + Math.Pow(number,2);
    }

    return squareSum;
}
try
{
   // Console.WriteLine($"Reached '0', stoped.") + function());
    Console.WriteLine(("Stopped. squareSum = ") + function());
}
catch
{
    Console.WriteLine("error");
}