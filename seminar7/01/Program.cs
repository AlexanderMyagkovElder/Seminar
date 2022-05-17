// задача из 4 семинара 3 задача, дз...про массив, заполняемый пользователем
string output = "3,5,54,68,7";
int countNumbers = 1;
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == ',')
        countNumbers++;
}
int[] numbers = new int[countNumbers];
int numberIndex = 0;
for (int i = 0; i < output.Length; i++)
{
    string substring = string.Empty;
    while (output[i] != ',')
    {
        substring += output[i].ToString();
        i++;
        if (i == output.Length)
        {
            break;
        }
    }
    numbers[numberIndex] = Convert.ToInt32(substring);
    numberIndex++;
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}