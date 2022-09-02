// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] RandomArray()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number]; // int[] array = new int[123]
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1001);
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
    return array;
}

void CountOfElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество элементов массива в отрезке [10,99] = {count}");        
}
CountOfElements(RandomArray());
