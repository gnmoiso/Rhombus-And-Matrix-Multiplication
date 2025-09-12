using Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };

do
{
    int size = ConsoleExtension.GetInt("Ingresa el tamaño del rombo: ");

    if (size % 2 == 0)
        Console.WriteLine("El tamaño debe ser un número impar.");
    else if (size < 03)
        Console.WriteLine("El tamaño debe ser mayor o igual a 3.");
    else
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

    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? [S]í / [N]o?....:  ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Saliendo del programa.");