/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


Console.WriteLine("Введите длину массива: ");
int LengthArray = int.Parse(Console.ReadLine()!);

int[] array = new int[LengthArray];
FillArray(array);

int count = 0;
for (int j = 0; j < LengthArray; j++)
    if (array[j] % 2 == 0)
    {
        count++;
    }

PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < LengthArray; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
}

void PrintArray(int[] array)
{
    string s = string.Join(", ", array);
    Console.WriteLine("[" + s + "]" + " -> " + count + " из них четные");
}

