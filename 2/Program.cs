Console.Write("Ведите число: ");
string text = Console.ReadLine();
int num = Convert.ToInt32(text);
int sum = 0;
int i = 0;


while (i < text.Length)
{
    int dig = Convert.ToInt32(Convert.ToString(text[i]));
    try
    {
        if ( num % dig == 0)
        {
            sum = sum + dig;
        
        }
        i++;
    }    
    catch (Exception ex)
    {i++;}
}
Console.Write("Сумма делителей: ");
Console.Write(sum);