const double RaioVermelho = 1;
const double RaioAzul = 3;
const double RaioAmarelo = 5;

double x, y, distanciaX, distanciaY, distanciaDardo;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("--- Dardos ---\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Digite a coordenada X..: ");
x = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Digite a coordenada Y..: ");
y = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

distanciaX = Math.Abs(x);
distanciaY = Math.Abs(y);

distanciaDardo = Math.Sqrt(Math.Pow(distanciaX, 2) + Math.Pow(distanciaY, 2));

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\nDistância do centro: {distanciaDardo:N2}\n");
Console.ResetColor();

if (distanciaDardo <= RaioVermelho)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Acertou na mosca!");
}
else if (distanciaDardo <= RaioAzul)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Arremesso bom.");
}
else if (distanciaDardo <= RaioAmarelo)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Arremesso ruim...");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Errou :(");
}

Console.ResetColor();
