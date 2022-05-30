/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/
Console.Write("Введите m: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[m, n];
GetArray(massive, m, n);
int[,]newMassive=new int[m,n];
if (m!=n)
{
    Console.WriteLine("Поменять местами строки и столбцы невозможно");
}
else
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMassive[i,j]=massive[j,i];
        }
    }
    Console.WriteLine();
    PrintArray(newMassive);
}


void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],-9}");
        }
        Console.WriteLine();
    }
}
void GetArray(int[,] array, int o, int p)
{
    for (int i = 0; i < o; i++)
    {
        for (int j = 0; j < p; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    for (int i = 0; i < o; i++)
    {
        for (int j = 0; j < p; j++)
        {
            Console.Write($"{array[i, j],-9}");
        }
        Console.WriteLine();
    }
}


