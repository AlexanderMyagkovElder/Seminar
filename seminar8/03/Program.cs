/*Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/
int m = InputNumber("Введите количество строк: ");
int n = InputNumber("Введите количество столбцов: ");
int[,]massive=new int[m,n];
GetArray(massive,m,n);
Console.WriteLine();
int predel=10;
for (int z = 0; z < predel; z++)
{
    Podbor(massive,z);   
}
int InputNumber(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void Podbor(int[,]array, int x)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (x==array[i,j])
            {
                sum++;
            }
        }
    }
    if (sum!=0) Console.WriteLine($"Число {x} встречалось {sum} раз");    
}
void GetArray(int[,] array, int o, int p)
{
    for (int i = 0; i < o; i++)
    {
        for (int j = 0; j < p; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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


