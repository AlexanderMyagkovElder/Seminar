/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */
Console.WriteLine("введите число: ");
int chislo=Convert.ToInt32(Console.ReadLine());
int temp=chislo;
int length=0;
while (chislo>0)
{
    chislo=chislo/2;
    length++;
}
int[] massive = new int[length];
for (int i = 0; i < massive.Length; i++)
{
    massive[i]=temp%2;
    temp=temp/2;
}
for (int i = 0; i < massive.Length/2; i++)
{
    temp=massive[i];
    massive[i]=massive[massive.Length-1-i];
    massive[massive.Length-1-i]=temp;
}
WriteArray(massive);
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
