// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int [] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-10, 10);
    }

}

void PrintArray(int[] newArray)
{   Console.WriteLine("Ваш массив:");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i]+" ");
    }
}

int Summ(int[] newArray)
{
    int summa = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i%2 != 0)
        summa = summa + newArray[i];
    } 
    Console.WriteLine($"Сумма чисел на нечетных позициях {summa}");
    return summa;
}

int size = InputNum("Введите размер массива: ");
int[] newArray = new int[size];

FillArray(newArray);
Console.WriteLine(" ");
PrintArray(newArray);
Console.WriteLine(" ");

Summ(newArray);