// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите значение n: ");
int n = int.Parse(Console.ReadLine());

double[,] result=new double[m,n];

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
         result[i,j] = new Random().NextDouble()*10;
        Console.Write(result[i,j]+" | ");
    } 
    Console.WriteLine(" ");
}
