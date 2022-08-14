// === Задать двумерный массив m на n и заполнить случайными целыми числами.
// Двумерный массив - матрица
// "," определяет кол-во индексов элементов на вход, их будет 2

/* int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод определения кол-ва строк и столбцов
{                                                               // и заполнения числами
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);

    return newArray;
}

void Show2dArray(int[,] array) // метод вывода на экран полученного 2D (двумерного) массива
{
    for(int i = 0; i < array.GetLength(0); i++) // GetLength - получить длину
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
Show2dArray(myArray); */

// === Задача 1. Задайте двумерный массив размера m на n  
// Каждый элемент в массиве находится по формуле: Array(ij) = i + j.
// Выведите полученный массив на экран.

/* int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод определения кол-ва строк и столбцов
                                                                            // и заполнения числами
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = i + j;

    return newArray;
}

void Show2dArray(int[,] array) // метод вывода на экран полученного 2D (двумерного) массива
{
    for(int i = 0; i < array.GetLength(0); i++) // GetLength - получить длину
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
Show2dArray(myArray); */

// === Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

    // метод создания рандомного 2D массива
/* int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue) + 1;

    return newArray;
}

    // метод преобразования полученного массива с заменой четных элементов на их квадраты
int[,] KvadratChet(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] = array[i, j] * array[i, j]; // либо *= - это умножение 

    return array;
}

    // метод вывода на экран полученного массива
void Show2dArray(int[,] array) 
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
KvadratChet(myArray);
Show2dArray(myArray); */


