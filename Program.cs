// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] FillArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int getUserData(string massage)
{
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i %2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = getUserData("Введите длинну массива");
int [] arr = FillArray(number,-100,100);
PrintArray(arr);
int S = FindSum(arr);
Console.WriteLine($"Сумма чисел в массиве стоящих на нечетных позициях = {S}");
