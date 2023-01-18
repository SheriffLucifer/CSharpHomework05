double[] array = GetRandomArray(5, 0, 99);
double differenceMaxMin = FindDifferenceMaxMin(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {differenceMaxMin}");

double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

double FindDifferenceMaxMin(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
        if (array[i] > maxValue) maxValue = array[i];
    }
    return maxValue - minValue;
}