//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rdn = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(min, max);
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
int SumOddElement(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i = i +2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.Write("Введите три целых числа : размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("нижняя граница массива   ");
int b  = Convert.ToInt32(Console.ReadLine());
Console.Write("верхняя граница массива   ");
int c = Convert.ToInt32(Console.ReadLine());
int[] newarray = FillArray(a,b,c);
Console.Write("В массиве ");
PrintArray(newarray);
Console.Write($" сумма элементов, стоящих на нечетных позициях ->  {SumOddElement(newarray)}");
