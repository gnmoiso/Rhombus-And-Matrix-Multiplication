using Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };

do
{
    var m = ConsoleExtension.GetInt("Ingrese el valor de m: ");
    var n = ConsoleExtension.GetInt("Ingrese el valor de n: ");
    var p = ConsoleExtension.GetInt("Ingrese el valor de p: ");

    if (n <= 0 || m <= 0 || p <= 0)
    {
        Console.WriteLine("Los valores deben ser mayores a 0.");
    }
    else
    {
        int[,] A = new int[m, n];
        int[,] B = new int[n, p];

        Console.WriteLine("***A***");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = (i + 1) * j;

                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***B***");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = (j + 1) * i;

                Console.Write($"{B[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***C***");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                var C = 0;
                for (int k = 0; k < n; k++)
                {
                    C += A[i, k] * B[k, j];
                }
                Console.Write($"{C} ");
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