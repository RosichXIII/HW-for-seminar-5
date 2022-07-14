//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Z36();

void Z36()
{
    Random random = new Random();
    int size = random.Next(3,26);
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
    SumOddIndex(array);
}

void FillArray(int[] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10,11);
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

void SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum += array[i];
        }

    }
    Console.Write("Сумма нечётных позиций: " + sum);
}