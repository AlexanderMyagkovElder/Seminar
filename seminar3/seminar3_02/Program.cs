/* Напишите программу, которая принимает на вход координаты 2х и находит 
расстояния между ними в 2D*/
Console.Write("Введите координату Х точки А: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
int y2=Convert.ToInt32(Console.ReadLine());
int Katet(int a,int b)
{
    int katet=(b-a)*(b-a);
    return katet;
}
double distance=Math.Sqrt(Katet(x1,x2)+Katet(y1,y2));
Console.WriteLine($"Расстояние между точками равно {distance}");