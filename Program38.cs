// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// создание массива вещественных чисел
double[] doubles = new double[5];
Random rnd = new Random();
int deviation = 10;
for (int i = 0; i < doubles.Length; i++)
{
    doubles[i] = Math.Round((rnd.NextDouble()- 0.5)*2*deviation, 2 );
}


// ввод массива
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


// распечатка массива
void PrintArray(double[] newArray)
{   Console.WriteLine("Ваш массив:");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i]+" ");
    }
}

double Raznica(double[] newArray)
{
    double raznica = 0;
    double min = 0;
    double max = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] < min)
        min = newArray[i];
        if (newArray[i] > max)
        max = newArray[i];
    raznica = max - min;
    } 
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива {raznica}");
    return raznica;
}

Console.WriteLine(" ");
PrintArray(doubles);
Console.WriteLine(" ");
Raznica(doubles);


