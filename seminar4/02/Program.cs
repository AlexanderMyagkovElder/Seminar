/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int kolvo = 0;
string number = Convert.ToString(chislo);
for (int i = 1; i <= number.Length; i++)
{
    kolvo += 1;
}
Console.WriteLine($"Количество цифр равно {kolvo}");