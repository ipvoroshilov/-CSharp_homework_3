// ## Задача 23

// ### Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string function()
 {
    Console.Write("Imput number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int count=1;
            string result = string.Empty;   //пустая строка
            while (count <= N)
            {
                result = result + Math.Pow(count, 3)+", ";
                count=count+1;             
            }
    return result;
 }
 try
 {
    Console.WriteLine(function());
 }
catch
{
    Console.WriteLine("Not number");
}