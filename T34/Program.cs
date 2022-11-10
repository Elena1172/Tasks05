//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rdn = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
int CountEvenNumber(int[] ar)
{
    int count = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0) count += 1;
    }
    return count;
}
Console.Write("Задайте количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[]newarray = FillArray(a);
Console.Write($"В массиве ");
PrintArray(newarray);
 Console.Write($" количество четных чисел -> {CountEvenNumber(newarray)}");
