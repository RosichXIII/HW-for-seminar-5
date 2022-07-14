//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Z38();

void Z38()
{
    Random random = new Random();
    int size = random.Next(3,16);
    double[] array = new double[size];

    FillArray(array);
    PrintArray(array);
    MinMaxDifference(array);   
}

void FillArray(double[] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble()*200 - 100, 2);
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine("Массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

void MinMaxDifference(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine("Максимальное значение: " + max);
    Console.WriteLine("Минимальное значение: " + min);
    Console.WriteLine("Разность значений: " + (max-min));
}