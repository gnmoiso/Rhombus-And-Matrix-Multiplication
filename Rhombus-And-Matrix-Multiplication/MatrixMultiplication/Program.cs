using Shared;

var answer = String.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    var m = ConsoleExtension.GetInt("Ingrese el valor de m: ");
    var n = ConsoleExtension.GetInt("Ingrese el valor de n: ");
    var p = ConsoleExtension.GetInt("Ingrese el valor de p: ");

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (MoreThanZero(m, n, p))
    {
        Console.WriteLine("Los valores deben ser mayores a 0. ");
    }
    else
    {
        int[,] A = new int[m, n];
        int[,] B = new int[n, p];

        MatrizA(A, m, n);
        MatrizB(B, n, p);
        MatrizC(A, B, m, n, p);
    }

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;

    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar? [S]í / [N]o?....:  ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Saliendo del programa.");
void MatrizC(int[,] A, int[,] B, int m, int n, int p)
{
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

void MatrizB(int[,] B, int n, int p)
{
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
}

void MatrizA(int[,] A, int m, int n)
{
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
}

bool MoreThanZero(int m, int n, int p)
{
    return m <= 0 || n <= 0 || p <= 0;
}