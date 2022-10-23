//Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите воличество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());

int [,]arr = new int [n, m];
int []sum = new int [m];
Random ran = new Random();

for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        arr[i, j] = ran.Next(0, 100);
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}


for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        sum[i] += arr[j, i];
    }
}


for (int i = 0; i < m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}
