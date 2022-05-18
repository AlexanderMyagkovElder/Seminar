/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */
Console.Write("Введите m: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] massive = new int[m,n];
int sum = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massive[i,j]=new Random().Next(0,10);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massive[i,j]+" ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i==j)
        {
            sum+=massive[i,j];
        }
    }
}

Console.WriteLine($"сумма равна {sum}");
