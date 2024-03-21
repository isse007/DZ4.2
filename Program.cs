// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int NumbersCount(int[] arr)
{
    int countNum = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countNum++;
        }
    }
    return countNum;
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine(NumbersCount(arr));