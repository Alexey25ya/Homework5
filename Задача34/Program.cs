// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] getArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int[] array = getArray(10);

int getResult(int[] array1)
{
    int count = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(string.Join(" | ", array));
Console.WriteLine("количество чётных чисел в массиве равно " + getResult(array));