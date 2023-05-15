//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

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

string NumbersRec(int n)
{
    if (n > 1) return $"{n} " + NumbersRec(n - 1);
    else return $"{n} ";
}

int numberN = GetNumber("Введите число n:");
Console.WriteLine($"Натуральные чисела от {numberN} до 1 = {NumbersRec(numberN)}");