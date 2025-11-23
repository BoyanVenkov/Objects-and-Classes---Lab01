using System.Numerics;

int input = int.Parse(Console.ReadLine());

BigInteger n = BigInteger.One;

for (int i = 1; i <= input; i++)
{
    n *= i;
}
Console.WriteLine(n);