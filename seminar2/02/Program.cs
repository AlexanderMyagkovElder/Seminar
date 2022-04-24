//выводит 3хзначное число и удаляет вторую цифру этого числа
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int chislo = Sotni(number);
int Sotni(int number)
{
    int chislo = number / 100;
    return chislo;
}

int chislo2 = Edinicy(number);
int Edinicy(int number)
{
    int chislo2 = number % 10;
    return chislo2;
}
int newchislo = chislo*10 + chislo2;
Console.WriteLine("Ваше числo: " + newchislo);