// Задача 1. Задать двумерный массив m на n и заполнить случайными целыми числами.
// Двумерный массив - матрица
// "," определяет кол-во индексов элементов на вход, их будет 2

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод определения матрицы массива
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);

    return newArray;
}

void Show2dArray(int[,] array) // метод заполения случайными целыми числами строки и столбцы
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
} 

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, 1, 9);
Show2dArray(myArray);

