// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine()); 
/// <summary>
/// программа реализует функцию Аккермана (формула вычисления и написания взята из Википедии)
/// </summary>
/// <param name="M"></param>
/// <param name="N"></param>
/// <returns></returns>
int FunctionAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return FunctionAkkerman(M-1, 1);
    return FunctionAkkerman(M - 1, FunctionAkkerman(M, N-1));
}
Console.WriteLine($"Вычисление при помощи функции Аккермана: {FunctionAkkerman(numberM, numberN)}");