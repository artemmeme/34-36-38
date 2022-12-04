//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int num in array)
        Console.Write($"{num} ");
    Console.WriteLine();
}

int Elements_find_2(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Elements_find_2(array);
Console.WriteLine($"Количество четных чисел - {Elements_find_2(array)}");
