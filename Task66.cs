//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetNumber(string massage)
{
    int resultNumber = 0;
    Console.WriteLine(massage);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
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

int SumRec(int m, int n)
{
    if (m == n) return m;
    else return m + SumRec(m + 1, n);
}

int numberM = GetNumber("Введите число m:");
int numberN = GetNumber("Введите число n (n>m):");
Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} = {SumRec(numberM, numberN)}");
