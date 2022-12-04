//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
decimal[] CreateArray(int size)
{
    decimal[] array = new decimal[size];
    for (int i = 0; i < size; i++)
        array[i] = Convert.ToDecimal(new Random().Next(100,1000)) / 100;
    return array;
}

void PrintArray(decimal[] array)
{
    foreach (decimal num in array)
        Console.Write($"{num} ");
    Console.WriteLine();
}

decimal Find_Max(decimal[] array)
{
    decimal max = array[0];
    foreach (decimal num in array)
        if (num > max)
        {
            max = num;
        }
    return max;
}

decimal Find_min(decimal[] array)
{
    decimal min = array[0];
    foreach (decimal num in array)
        if (num < min)
        {
            min = num;
        }

    return min;
}

decimal delta(decimal[] array)
{
decimal delta = 0;
    delta = Find_Max(array) - Find_min(array);
    return delta;
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
decimal[] array = CreateArray(size);
PrintArray(array);
Find_Max(array);
Find_min(array);
delta(array);
Console.WriteLine($"Максимальное число = {Find_Max(array)}");
Console.WriteLine($"Минимальное число = {Find_min(array)}");
Console.WriteLine($"Разница между max и min = {delta(array)}");

