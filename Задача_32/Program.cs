// Задача 32: Напишите программу замены элементов массива 
// (положительные элементы замените на соответствующие отрицательные, и наоборот).
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void ChangeElements()
{
    Console.Write("Введите длину массива: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

    for (int j = 0; j < array.Length; j++)
    {
        array[j] = -array[j];
    }
    Console.WriteLine($"Массив с заменёнными элементами: [{String.Join(", ", array)}]");
}

ChangeElements();
