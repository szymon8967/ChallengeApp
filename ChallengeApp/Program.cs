int[] counters = new int[10];
int number = 4566;
Console.WriteLine(number);
string numberAsString = number.ToString();
char[] signs = numberAsString.ToCharArray();
foreach (char sign in signs)
{
    if (sign == '0')
    {
        counters[0] ++;
    }
    else if (sign == '1') 
    {
        counters[1]++;
    }
    else if (sign == '2')
    {
        counters[2]++;
    }
    else if (sign == '3')
    {
        counters[3]++;
    }
    else if (sign == '4')
    {
        counters[4]++;
    }
    else if (sign == '5')
    {
        counters[5]++;
    }
    else if (sign == '6')
    {
        counters[6]++;
    }
    else if (sign == '7')
    {
        counters[7]++;
    }
    else if (sign == '8')
    {
        counters[8]++;
    }
    else if (sign == '9')
    {
        counters[9]++;
    }
}
for(var i=0; i<counters.Length; i++)
{
    Console.WriteLine(i+"->"+counters[i]);
}