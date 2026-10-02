Console.WriteLine("Informe 3 números maiores que zero");
decimal num1 = 0, num2 = 0, num3 = 0;
bool obterNum = false;

while (!obterNum)
{
    Console.Write("1º número: ");
    num1 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);

    if (num1 < 0)
    {
        Console.WriteLine("Digite somente números maiores que 0");
        obterNum = false;
    }
    else
        obterNum = true;
}

obterNum = false;

while (!obterNum)
{
    Console.Write("2º número: ");
    num2 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);

    if (num2 < 0)
    {
        Console.WriteLine("Digite somente números maiores que 0");
        obterNum = false;
    }
    else
        obterNum = true;
}

obterNum = false;

while (!obterNum)
{
    Console.Write("3º número: ");
    num3 = Math.Round(Convert.ToDecimal(Console.ReadLine()), 1);

    if (num3 < 0)
    {
        Console.WriteLine("Digite somente números maiores que 0");
        obterNum = false;
    }
    else
        obterNum = true;
}

decimal semiperimetro = (num1 + num2 + num3) / 2;
decimal conta1 = semiperimetro - num1;
decimal conta2 = semiperimetro - num2;
decimal conta3 = semiperimetro - num3;
decimal resultado = semiperimetro * conta1 * conta2 * conta3;

resultado = (decimal)Math.Sqrt(Convert.ToDouble(resultado));

Console.WriteLine($"A área do triângulo é: {resultado}");
Console.WriteLine($"Perímetro do triângulo é: {semiperimetro}");
{
}