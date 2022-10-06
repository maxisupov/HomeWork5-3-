// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] arr = GetArray(10, 0, 100);
Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.Write($"Разницу между максимальным и минимальным элементом массива = { MaxNum(arr) - MinNum(arr)}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int MaxNum(int[] array)
{
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] > max)
    {
        max = array[i];
    }
    
}
return max;
}

int MinNum(int[] array1)
{
int min = 100;
for (int i = 0; i < array1.Length; i++)
{
    
    if (array1[i] < min)
    {
        min = array1[i];
    } 
}
 return min;
}