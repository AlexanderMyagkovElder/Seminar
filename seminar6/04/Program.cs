/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] fibo = new int[n];
fibo[0] = 0;
fibo[1] = 1;
for (int i = 2; i < n; i++)
{
    fibo[i] = fibo[i - 1] + fibo[i - 2];
}
WriteArray(fibo);

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
