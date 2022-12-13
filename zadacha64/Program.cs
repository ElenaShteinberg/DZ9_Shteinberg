// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


void Recursion(int number1, int number2)
{
    if (number1 > number2) return;
    if (number1 % 3 == 0)
    {
        Console.Write($"{number1}  ");
    }
    number1++;
    Recursion(number1, number2);
}

Recursion(number1, number2);