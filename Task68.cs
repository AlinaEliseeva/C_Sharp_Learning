//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetNumber(string massage)
{
    int resultNumber = 0;
    Console.WriteLine(massage);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (m != 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int numberM = GetNumber("Введите число m:");
int numberN = GetNumber("Введите число n:");
Console.WriteLine($"Функция Аккермана А({numberM},{numberN}) = {Akkerman(numberM, numberN)}");

