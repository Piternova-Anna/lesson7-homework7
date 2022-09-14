// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int m = new Random().Next(2,10);
Console.WriteLine("количество столбцов: "+m);
int n = new Random().Next(2,10);
Console.WriteLine("количество строк: "+n);

int[,] array=new int[m,n];

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j]+" | ");
    } 
    Console.WriteLine(" ");
}
Console.WriteLine("введите номер столбца искомого элемента массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер строчки искомого элемента массива: ");
int y = int.Parse(Console.ReadLine());

if (x >= m || y >= n)
    {
        Console.WriteLine("заданной позиции в данном массиве НЕТ.");
    }
else
{
    int i = x;
    int j = y;
    Console.WriteLine("искомый элемент массива: "+array[i,j]);
}