// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел = 29, сумма отрицательных = -20.

void SummOfNumbers()
{
    int[] array = new int[12];

    int sumPositive = 0; 
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
    Console.WriteLine($"Сумма положительных элементов массива: = {sumPositive}");
    Console.WriteLine($"Сумма отрицательных элементов массива: = {sumNegative}");
}

SummOfNumbers();
