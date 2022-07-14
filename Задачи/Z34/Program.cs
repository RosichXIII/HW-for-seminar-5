//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Z34();

void Z34()
{
    Random random = new Random();
    int size = random.Next(3,16);
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
    EvenCount(array);
}

void FillArray(int[] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void EvenCount(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Массив не содержит чётных чисел");
    }
    else
    {
        Console.WriteLine($"Количество чётных чисел: {count}");
    }
}