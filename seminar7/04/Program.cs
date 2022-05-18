/*Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */
Console.WriteLine("Введите m: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massive[i,j]=i+j;
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massive[i,j]);
    }
    Console.WriteLine();
}