var liczba = 4634655888999;
int abundance;
var liczbaAsString = liczba.ToString();
char[] warred = liczbaAsString.ToArray();

for (char a = '0'; a <= '9'; a++)
{
    abundance = 0;
    for (int g = 0; g < warred.Length; g += 1)
    {
        if (warred[g] == a)
        {
            abundance++;
        }
    }
    Console.WriteLine(a.ToString() + "=>" + abundance.ToString());
}