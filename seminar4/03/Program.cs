/* Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
int [] massive = new int[8];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(0, 2);
    Console.Write(massive[i]+" ");
}
