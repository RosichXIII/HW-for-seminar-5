//Задача 2. На вход подаются два числа случайной длины.
//Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.
//24, 132 -> {2, 6, 4, 4, 12, 8}

DZ2();

void DZ2()
{
    Random random = new Random();
    int numberFirst = random.Next(10, 1000);
    int numberSecond = random.Next(10, 1000);
    int radixFirst = numberFirst.ToString().Length;
    int radixSecond = numberSecond.ToString().Length;
    int[] arrayFirst = new int[radixFirst];
    int[] arraySecond = new int[radixSecond];
        
    NumberToArray(numberFirst, numberSecond, arrayFirst, arraySecond);

    int size = radixFirst*radixSecond;
    int[] array = new int[size];
           
    FillArray(arrayFirst, arraySecond, array);
    PrintArray(numberFirst, numberSecond, array);
}

void NumberToArray(int numberFirst, int numberSecond, int[] arrayFirst, int[] arraySecond)
{
    for (int i = arrayFirst.Length - 1; i >= 0; i--)
    {
        arrayFirst[i] = numberFirst%10;
        numberFirst/=10;
    }

    for (int i = arraySecond.Length - 1; i >= 0; i--)
    {
        arraySecond[i] = numberSecond%10;
        numberSecond/=10;
    }
}

void FillArray(int[] arrayFirst, int[] arraySecond, int[] array)
{       
    int i = 0;
    
    for (int j = 0; j < arrayFirst.Length; j++)
    {
        for (int k = 0; k < arraySecond.Length; k++)
        {
            array[i] = arrayFirst[j] * arraySecond[k];
            i++;
        }
    }
}

void PrintArray(int numberFirst, int numberSecond, int[] array)
{
    Console.WriteLine();
    Console.Write($"Результат поразрядного уножения {numberFirst} на {numberSecond}: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
