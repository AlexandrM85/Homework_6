// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("--------------Задача №41.--------------");
int[] array = GetArray(8, -10, 10);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Пользователь ввел чисел больше 0:  {PositiveCount(array)}.");

int PositiveCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("--------------Задача №43.--------------");
Console.Write("Введите значение b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых: {x}; {y}.");
