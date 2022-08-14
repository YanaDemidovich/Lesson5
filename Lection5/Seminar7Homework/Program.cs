// === Задача 47. Задайте двумерный массив размером m × n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/* Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

void CreateArrayDouble(double[,] array)// метод генерации Random вещественных чисел
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)// метод округляет значение до ближайшего целого или указанного количества десятичных знаков.
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine(); */

// === Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

/* int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)// метод генерации Random целых чисел
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue) + 1;

    return newArray;
}

void Show2dArray(int[,] array)// метод вывода значений рандомных чисел в 2-х мерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();

    }
}

string FindElement(int[,] value, int line, int columns) //метод возвращает значение этого элемента
{
    if (line < value.GetLength(0) && columns < value.GetLength(1))
    {
        return value[line, columns].ToString();
    }
    else return "Такого элемента нет.";
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(m, n, 1, 9);
Show2dArray(myArray);
Console.WriteLine();

Console.WriteLine(FindElement(myArray, 1, 2));
Console.WriteLine(); */

// === Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] massive = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; //заднный масив

void WriteArrayInt(int[,] massive)// метод вывода масива
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
}

WriteArrayInt(massive);

Console.WriteLine("Cреднее арифметическое:");

double[] Mean(int[,] value) // метод вычисления среднее арефметическое элементов в каждом столбце
{
    double[] mean = new double[value.GetLength(1)];
    for (int i = 0; i < value.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < value.GetLength(0); j++)
        {
            sum += value[j, i];
        }
        mean[i] = Math.Round((double)sum / value.GetLength(0), 2);

    }
    return mean;
}

PrintMasively(Mean(massive));

void PrintMasively(double[] value) // метод обрезания строки чтобы привести к заданому примеру.
{
    for(int i = 0; i < value.Length; i++)
    {
        if(value[i].ToString().Length>2)
        Console.Write(value[i].ToString().Substring(0,3) + ";  ");
        else
        Console.Write(value[i].ToString() + "  ");
    }
    
}
Console.WriteLine($"\n ");

