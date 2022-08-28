// ### Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string function()
{
    Console.WriteLine("imput 5-digit number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 10000 & number < 100000)
    {
        int digit1 = number/10000;
        int digit5 = number%10;
        int digit2 = number%10000/1000;
        int digit4 = number%100/10;
        if (digit1==digit5 & digit2==digit4) return "YES";
        else return "NO";
    }
    else return "It is not 5-digit number!!";
}
try
{
    Console.WriteLine(function());

}
catch
{
    Console.WriteLine("not number");  
}