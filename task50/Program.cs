
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Строка 1
// Столбец 2
// Вывод: 4

Console.Clear();

void InputMatrix(int[,] matrix)

{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [n,m];
InputMatrix(matrix);

Console.WriteLine("Введите позицию строки:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Искомый элемент массива: {matrix[x-1,y-1]}");