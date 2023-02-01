Console.Write("Число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень: ");
int n = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int pow)
{
    int i = 1;
    int result = 1;
    while (i <= pow)
    {
        result = result * num;
        i++;
    }
    return result;
}

Console.Write(Pow(x, n));