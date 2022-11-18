/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите длину массива: ");
int LengthArray = int.Parse(Console.ReadLine()!);

int[] array = new int[LengthArray];
FillArray(array);

int sum = 0;
for (int j = 0; j < LengthArray; j++)
    if (j % 2 == 0)
    {
        sum+=array[j];
    }

PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < LengthArray; i++)
        {
            array[i] = new Random().Next(-100, 100);
        }
}

void PrintArray(int[] array)
{
    string s = string.Join(", ", array);
    Console.WriteLine("[" + s + "]" + " -> " + sum + " сумма элементов, стоящих на нечётных позициях.");
}
