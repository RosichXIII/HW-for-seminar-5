//Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений.
//Подсчитайте их количество.

DZ3();

void DZ3()
{
    int targetNumber = 1000000;
    int number = 1;
    int count = 0;
    int digitSum = 0;
    int digitMult = 1;

    while (number <= targetNumber)
    {
        SumOfDigits(number, digitSum);
        MultOfDigits(number, digitMult);

        if (digitSum*3 == digitMult)
        {
            count++;
            number++;
        }
        else
        {
            number++;
        }
    }

    if (count == 0)
    {
        Console.WriteLine("Таких чисел нет");
    }
    else
    {
        Console.WriteLine("Кол-во чисел, сумма цифр которых в три раза меньше их произведений: " + count);
    }
}

void SumOfDigits(int number, int digitSum)
{
    int currentNumber = number;
    digitSum = 0;
    while (currentNumber > 0)
    {
        digitSum +=currentNumber%10;
        currentNumber /=10;
    }
}

void MultOfDigits(int number, int digitMult)
{
    int currentNumber = number;
    digitMult = 1;
    while (currentNumber > 0)
    {
        digitMult *=currentNumber%10;
        currentNumber /=10;
    }
}