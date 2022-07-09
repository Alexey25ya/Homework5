// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// Некорректные условия:
// 1)Вещественные числа не использовал - в контексте задачи они не нужны
// 2)Разницу понял как разность

int[] getArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 11);
    }
    return arr;
}

int[] array = getArray(10);

int getMin(int[] array1)
{
    int min = array1[0];
    for (int j = 0; j < array1.Length; j++)
    {
        if (min > array1[j])
        {
            min = array1[j];
        }
    }
    return min;
}

int getMax(int[] array2)
{
    int max = array2[0];
    for (int l = 0; l < array2.Length; l++)
    {
        if (max < array2[l])
        {
            max = array2[l];
        }
    }
    return max;
}
Console.WriteLine(string.Join(" | ", array));
Console.WriteLine(getMax(array));
Console.WriteLine(getMin(array));
Console.WriteLine($" разность между максимальным и минимальным элементами массива  {getMax(array)-getMin(array)} ");