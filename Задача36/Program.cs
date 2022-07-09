// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] getArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

int[] array = getArray(10);

int getResult(int[] array1)
{
    int sum = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (j % 2 == 0) // нечетная позиция == четный индекс
        {
            sum+=array1[j];
        }
    }
    return sum;
}
Console.WriteLine(string.Join(" | ", array));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна " + getResult(array));