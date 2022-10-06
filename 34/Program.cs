// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] arr = GetArray(10, 100, 999);
Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.Write($"Количество чётных чисел в массиве = {HowManyEven(arr)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}



int HowManyEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)

    
    if (array[i] % 2 == 0)
    {
        count++;
    }
    return count;
 
}
