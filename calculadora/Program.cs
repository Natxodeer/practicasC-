int option=1;

while (option != 0)
{
    Console.WriteLine("Welcome to the Calculator!!!");
    Console.WriteLine("1. sumar");
    Console.WriteLine("2. restar");
    Console.WriteLine("3. multiplicar");
    Console.WriteLine("4. dividir");
    Console.WriteLine("5. sumar N fracciones");
    Console.WriteLine("0. salir");
    Console.Write("Escoge una opción.....: ");
    string? optionString = Console.ReadLine();
    if (optionString == null || optionString == "")
    {
        option = 0;
      
    }
    else option = int.Parse(optionString);

    if (option != 0)
    {
        Calcula(option);
    }
   
}

void Calcula (int option)
{
    int n1, d1, n2, d2;
    int resultadoNum, resultadoDen;
    const int TAM_MAX = 50;
    int[] numeradores = new int[TAM_MAX];
    int[] denominadores = new int[TAM_MAX];
    int numFrac;

    if (option == 1)
    {
        Console.WriteLine("Sumar");

        LeerFraccion(out n1, out d1);
        LeerFraccion(out n2, out d2);
        Sumar(n1, d1, n2, d2,out resultadoNum, out resultadoDen);
        Console.WriteLine($"El resultad de sumar {n1}/{d1} + {n2}/{d2} es: {resultadoNum}/{resultadoDen}");
    }

    if (option == 2)
    {
        Console.WriteLine("Restar");
        LeerFraccion(out n1, out d1);
        LeerFraccion(out n2, out d2);
        Restar(n1, d1, n2, d2, out resultadoNum, out resultadoDen);
        Console.WriteLine($"El resultad de restar {n1}/{d1} - {n2}/{d2} es: {resultadoNum}/{resultadoDen}");

    }

    if (option == 3)
    {
        Console.WriteLine("Multiplicar");
        LeerFraccion(out n1, out d1);
        LeerFraccion(out n2, out d2);
        Multiplicar(n1, d1, n2, d2, out resultadoNum, out resultadoDen);
        Console.WriteLine($"El resultad de multiplicar {n1}/{d1} * {n2}/{d2} es: {resultadoNum}/{resultadoDen}");

    }

    if (option == 4)
    {
        Console.WriteLine("Dividir");
        LeerFraccion(out n1, out d1);
        LeerFraccion(out n2, out d2);
        Dividir(n1, d1, n2, d2, out resultadoNum, out resultadoDen);
        Console.WriteLine($"El resultad de dividir {n1}/{d1} : {n2}/{d2} es: {resultadoNum}/{resultadoDen}");

    }
    if (option == 5)
    {
        Console.WriteLine("Sumar N fracciones");
        Console.Write("Cuantas fracciones quieres sumar: ");
        numFrac = Convert.ToInt32(Console.ReadLine());
        LeerNFracciones( numeradores,  denominadores, numFrac);
        for (int i = 0; i< numFrac; i++)
        {
            Console.WriteLine($"{numeradores[i]}/{denominadores[i]}");
        }
       // SumarNFracciones(numeradores, denominadores,numFrac, resultadoNum, out resultadoDen);

    }
}

void LeerFraccion (out int n,out int d)
{
    Console.Write("Dame el numerador: ");
    n= Convert.ToInt32(Console.ReadLine());
    Console.Write("Dame el denominador: ");
    d = Convert.ToInt32(Console.ReadLine());
}
void LeerNFracciones( int[] numeradores,  int[] denominadores,int n)
{
    for (int i = 0; i < n; i++)
    {
        LeerFraccion(out numeradores[i], out denominadores[i]);
    }
}

void Sumar(int n1, int d1, int n2, int d2, out int resultadoNum, out int resultadoDen)
{
    resultadoNum = n1 * d2 + n2 * d1;
    resultadoDen = d1 * d2;
}
void Restar(int n1, int d1, int n2, int d2, out int resultadoNum, out int resultadoDen)
{
    resultadoNum = n1 * d2 - n2 * d1;
    resultadoDen = d1 * d2;
}
void Multiplicar(int n1, int d1, int n2, int d2, out int resultadoNum, out int resultadoDen)
{
    resultadoNum = n1 * n2 ;
    resultadoDen = d1 * d2;
}
void Dividir(int n1, int d1, int n2, int d2, out int resultadoNum, out int resultadoDen)
{
    resultadoNum = n1 * d2;
    resultadoDen = d1 * n2;
}
void SumarNFracciones(int[] numeradores, int[] denominadores, int n,  int resultadoNumerador,  int resultadoDenominador)
{
    resultadoDenominador = 1;
    for (int i = 0; i < n; i++)
    {
       resultadoDenominador = resultadoDenominador * denominadores[i];
    }
}