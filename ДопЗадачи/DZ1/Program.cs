//Задача 1. Задан массив из случайных цифр на 15 элементов.
//На вход подаётся трёхзначное натуральное число. Напишите программу,
//которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
//{0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
//{4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет

DZ1();

void DZ1()
{
    int size = 15;
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
    
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());

    CheckDigitSequence(number, array);
}

void FillArray(int[] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
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

void CheckDigitSequence(int number, int[] array)
{
    int sequenceCount = 0;
    for (int i = 0; i < array.Length-2; i++)
    {
        if (number/100 == array[i] & number/10%10 == array[i+1] & number%10 == array[i+2])
        {
            sequenceCount++;
        }
    }
    if (sequenceCount > 0)
    {
        Console.WriteLine($"Число {number} встречается {sequenceCount} раз(а)");
    }
    else
    {
        Console.WriteLine($"Числа {number} нет");
    }
}