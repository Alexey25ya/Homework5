// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double[] getArray(int n)
{
    double[] arr = new double[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(-100, 101)/10.0);
    }
    return arr;
}

double[] array = getArray(10);

double getMin(double[] array1)
{
    double min = array1[0];
    for (int j = 0; j < array1.Length; j++)
    {
        if (min > array1[j])
        {
            min = array1[j];
        }
    }
    return min;
}

double getMax(double[] array2)
{
    double max = array2[0];
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