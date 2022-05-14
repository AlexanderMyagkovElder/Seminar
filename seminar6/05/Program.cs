/* Задача 45: Напишите программу, которая будет создавать копию заданного массива
 с помощью поэлементного копирования.*/
 Console.Write("Введите длинну массива: ");
 int dlinna=Convert.ToInt32(Console.ReadLine());
 int[] array= GetArray(dlinna);
 WriteArray(array);
 int[] massive=new int[dlinna];
 for (int i = 0; i < array.Length; i++)
 {
     massive[i]=array[i];
 }
 WriteArray(massive);
 
 
 
 void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] GetArray(int length)
{
    int[] newArray = new int[length];
    FillArray(newArray);
    return newArray;
}
