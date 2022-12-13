// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int sum = 0;


void Recursion(int number1, int number2, int sum)
{
    if (number1 > number2)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += number1;
    number1++;
    Recursion(number1, number2, sum);
}

Console.WriteLine($"Сумма чисел от {number1} до {number2} равна:");
Recursion(number1, number2, sum);