//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] FillArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
double MaxArray(double[]array){
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
       if(array[i] > max) max = array[i]; 
    }
    return max;
}
double MinArray(double[]array){
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
       if(array[i] < min) min = array[i]; 
    }
    return min;
}
Console.Write("Введите три целых числа : размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("нижняя граница массива   ");
int b  = Convert.ToInt32(Console.ReadLine());
Console.Write("верхняя граница массива   ");
int c = Convert.ToInt32(Console.ReadLine());
double[] d = FillArray(a,b,c);
Console.Write($"В заданном массиве ");
PrintArray(d);
Console.Write($" разница между максимальным и минимальным значениями -> {Math.Round(MaxArray(d)-MinArray(d),2)} ");
