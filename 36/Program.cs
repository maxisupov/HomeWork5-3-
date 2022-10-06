// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] arr = GetArray(10, -100, 100);
Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.Write($"Cуммa элементов, стоящих на нечётных позициях = {SumOdd(arr)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)

    if ( i % 2 != 0)
    {
        sum = sum + array[i];
    }
    return sum;
 
}