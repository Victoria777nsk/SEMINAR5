// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, -3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] EnterRandomArray()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }

    return array;
}


bool IsInArray(int[] array)
{
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
    Console.Write("Введите число для поиска в массиве: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }

    return false;
}

Console.WriteLine(IsInArray(EnterRandomArray()));
