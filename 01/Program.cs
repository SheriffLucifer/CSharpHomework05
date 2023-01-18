int[] array = GetRandomArray(50, 100, 999);
int evenElements = FindEvenElements(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {evenElements}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int FindEvenElements(int[] array)
{
    int evenElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenElement++;
    }
    return evenElement;
}