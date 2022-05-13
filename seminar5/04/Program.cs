/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int elements = new Random().Next(3, 11);
int[] massive = new int[elements];
int dlinnaMulti = 0;
if (elements % 2 == 0)
{
    dlinnaMulti = elements / 2;
}
else dlinnaMulti = elements / 2 + 1;
int[] multi = new int[dlinnaMulti];
int multiplic = 0;
Zapolnenie(massive);
if (massive.Length % 2 == 0)
{
    for (int i = 0; i < massive.Length / 2; i++)
    {
        multiplic = massive[i] * massive[massive.Length - i - 1];
        multi[i] = multiplic;
    }
}
else
{
    for (int i = 0; i < massive.Length / 2; i++)
    {
        multiplic = massive[i] * massive[massive.Length - i - 1];
        multi[i] = multiplic;
    }
    multi[multi.Length - 1] = massive[(massive.Length / 2)];
}
PrintArray(multi);




void Zapolnenie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}