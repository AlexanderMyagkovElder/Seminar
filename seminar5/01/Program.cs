/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.*/

Console.WriteLine("Введите интервал чисел: от ");
int from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите интервал чисел: до ");
int to = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[12];
int sumplus=0;
int summinus=0;
void Zapolnenie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Zapolnenie(massive);
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i]>0) sumplus+=massive[i];
    else summinus+=massive[i];
}
Console.WriteLine($"Сумма положительных чисел равна {sumplus}");
Console.WriteLine($"Сумма отрицательных чисел равна {summinus}");

