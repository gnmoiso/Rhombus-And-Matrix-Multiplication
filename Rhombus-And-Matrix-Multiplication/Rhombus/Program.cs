using Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    int size = ConsoleExtension.GetInt("Ingresa el tamaño del rombo: ");

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;
    DrawRhombus(size);

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;

    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? [S]í / [N]o?....:  ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Saliendo del programa.");
void DrawRhombus(int size)
{
    if (SizeIsOdd(size))
    {
        Console.WriteLine("El tamaño debe ser un número impar.");
    }
    else if (SIzeMinor(size))
    {
        Console.WriteLine("El tamaño debe ser mayor o igual a 3.");
    }
    else
    {
        OrderDrawSize(size);
    }
}

void OrderDrawSize(int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (j == Math.Abs(size / 2 - i) || j == size - 1 - Math.Abs(size / 2 - i))
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

bool SIzeMinor(int size)
{
    return size < 3;
}

bool SizeIsOdd(int size)
{
    return size % 2 == 0 & size > 3;
}