/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. */
int [] massive = new int[123];
Zapolnenie(massive);
int sum = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] < 100 && massive[i] > 9)
    {
        sum += 1;
    }
}
Console.WriteLine(sum);

void Zapolnenie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        massive[i] = new Random().Next(0, 1000);
        Console.Write(massive[i]+" ");
    }
    Console.WriteLine();
}
