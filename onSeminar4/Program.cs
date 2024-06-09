using System.ComponentModel.DataAnnotations;

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];
Random rand = new Random();

int count = 0;

for (int i = 0; i < arraySize; i++)
{
    array[i] = rand.Next(15, 22);
    Console.Write(array[i] + " ");
    if (array[i] % 7 == 0 && array[i] % 10 == 1)
    {
        count++;
    }
}

Console.Write("\n" + count);