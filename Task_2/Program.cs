// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// !!!!!!!!!!!условие задачи непонятно. моя программа рандомно создает массив и печатает его. затем пользаватель вводит
//какое-то число. если оно имеется в массиве то выводятся все позиции где оно стоит.
Console.Clear();

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
PrintArray(matrix);
System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool stop = false;
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        if (number == matrix[rows, columns])
        {
            System.Console.WriteLine($"Ваше число находится в {rows + 1} строке и в {columns + 1} столбце ");
            stop = true;
        }
    }
}
if (stop == false)
{
    System.Console.WriteLine("Такого числа в массиве нет");
}