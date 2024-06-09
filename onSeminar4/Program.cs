using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

void Main()
{
    // Console.Write("Введите размер массива: ");
    // int arraySize = Convert.ToInt32(Console.ReadLine()); // добавили ReadInt
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 15, 22);
    PrintArray(array);
    Console.WriteLine(CountNumbers(array));

    // int[] array2 = GenerateArray(5, 0, 100);
    //PrintArray(array2);

    // int[] array = new int[arraySize]; // эти строки заменяет функция генерации
    // Random rand = new Random();

    // int count = 0;

    // for (int i = 0; i < arraySize; i++)
    // {
    //     array[i] = rand.Next(15, 22);
    //     Console.Write(array[i] + " ");
    //     if (array[i] % 7 == 0 && array[i] % 10 == 1)
    //     {
    //         count++;
    //     }
    // }
    // Console.Write("\n" + count);
}

int CountNumbers(int[] anyArray)
{
    int count = 0;
    for (int i = 0; i < anyArray.Length; i++)
    {
        if (anyArray[i] % 7 == 0 && anyArray[i] % 10 == 1)
        {
            count++;
        }
    }
    return count;
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    // int count = 0;

    for (int i = 0; i < size; i++) // заменили на функцию PrintArray
    {
        tempArray[i] = rand.Next(minRange, maxRange + 1);
        // Console.Write(tempArray[i] + " ");
        // if (tempArray[i] % 7 == 0 && tempArray[i] % 10 == 1)
        // {
        //     count++;
        // }
    }
    // Console.Write("\n" + count);
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string msg)
{
    Console.Write(msg);
    // int number = Convert.ToInt32(Console.ReadLine());
    // return number; // объединяем эти две строчки
    return Convert.ToInt32(Console.ReadLine());
}
Main();
