// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печатаем вес натуральные числа в промежутке от N до 1.
/// </summary>
/// <param name="start"></param>
/// <param name="end"></param>
/// <returns></returns>
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start-1, end));
}
Console.WriteLine($"Натуральные числа в промежутке от N до 1: {PrintNumbers(N, 1)}");
