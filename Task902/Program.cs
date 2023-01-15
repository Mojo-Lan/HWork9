// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void SumNumber(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма равна: {sum}");
        return;
    }
    sum = sum + (numberM++);
    SumNumber(numberM, numberN, sum);
}
SumNumber(numberM, numberN, 0);

