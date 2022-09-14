//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = new Random().Next(2,10);
Console.WriteLine("количество столбцов: "+m);
int n = new Random().Next(2,10);
Console.WriteLine("количество строк: "+n);

int[,] result=new int[m,n];

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        result[i,j] = new Random().Next(1,10);
        Console.Write(result[i,j]+" | ");
    } 
    Console.WriteLine(" ");
}

for (int i = 0; i < m; i++)
{
    double sum = 0;

    for (int j = 0; j < n; j++)
    {
        sum=sum+result[i,j];
    }
    double ArithmeticMean=sum/n;
    Console.WriteLine("среднее арифметическое столбца "+i+" : " + ArithmeticMean);
}

