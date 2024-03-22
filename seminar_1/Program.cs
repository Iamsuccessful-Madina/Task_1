// Напишите программу, которая на вход принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);

// Напишите программу, которпая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N 

int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;

while (notN <= N)
{
    Console.Write($"{notN} ");
    notN++;
}