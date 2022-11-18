/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите длину массива");
int LengthArray = Convert.ToInt32(Console.ReadLine());
double[] array = new double[LengthArray];

FillArray(array);
PrintArray(array);

double min = double.MaxValue;
double max = double.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}

void FillArray(double[] array)
{
    for (int i = 0; i < LengthArray; i++)
        {
            array[i] =Convert.ToDouble(new Random().Next(-10000, 10000))/100;
        }
}

void PrintArray(double[] array)
{
    string s = string.Join("; ", array);
    Console.WriteLine("Массив: [" + s + "]");
}

Console.WriteLine("Максимальное зачение = " + max);
Console.WriteLine("Минимальное зачение = " + min);
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");