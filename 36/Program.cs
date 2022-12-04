//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
//[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-10, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int num in array)
        Console.Write($"{num} ");
    Console.WriteLine();
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Sum(array);
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < size; i=i+2)
        sum=sum+array[i];
    return sum;
}
Console.WriteLine($"Сумма чисел на нечетных местах = {Sum(array)}");
