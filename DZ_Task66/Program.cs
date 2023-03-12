// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine()); 
/// <summary>
/// программа выведет сумму натуральных элементов от M до N.
/// </summary>
/// <param name="initNumber"></param>
/// <param name="finalNumber"></param>
/// <returns></returns>
int SumValue(int initNumber, int finalNumber)
{
    if (initNumber == finalNumber) return finalNumber;
    return (initNumber + SumValue(initNumber + 1, finalNumber));
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {SumValue(numberM, numberN)}");