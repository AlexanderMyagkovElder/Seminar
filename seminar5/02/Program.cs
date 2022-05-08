/*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
int [] massive = new int[5];
Zapolnenie(massive);
PrintArray(massive);
Console.WriteLine("Введите искомое число: ");
int search = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i]==search) 
    {
        Console.WriteLine($"Число {search} есть в массиве");
        break;
    }
    else if (i==massive.Length-1)
    Console.WriteLine($"Числа {search} нет в массиве");
}

void Zapolnenie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());        
    }
    Console.WriteLine();
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}