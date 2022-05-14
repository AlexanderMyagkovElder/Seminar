/*напишите программу,которая перевернет одномерный массив
(последний элемент - первый, первый - последний)*/
int[] array=GetArray(5);
WriteArray(array);
for (int i = 0; i < array.Length/2; i++)
{
    int temp=array[i];
    array[i]=array[array.Length-1-i];
    array[array.Length-1-i]=temp;
}
WriteArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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