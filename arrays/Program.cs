int option = 1;
const int TAM_MAX = 500;

while (option != 0)
{
    Console.WriteLine("Welcome to the Arrays training!!!");
    Console.WriteLine("1. Build an array of n lenght ");
    Console.WriteLine("2. Build an array of n lenght of strings");
    Console.WriteLine("3. Addition of two arrays");
    Console.WriteLine("0. Exit");
    Console.Write("Choose.....: ");
    string? optionString = Console.ReadLine();
    if (optionString == null || optionString == "")
    {
        option = 0;

    }
    else option = int.Parse(optionString);

    switch (option)
    {
        case 1:
            BuildArrayN(option);
            break;
        case 2:
            BuildArrayStringN(option);
            break;
        case 3:
            {
                int[] numArray = new int[TAM_MAX];
                int[] numArray2 = new int[TAM_MAX];
                int[] result = new int[TAM_MAX];
                Console.Write("Give me the length of the array: ");
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                ReadArray(numArray, arrayLength);
                Console.Write("Give me the length of the array: ");
                ReadArray(numArray2, arrayLength);
                AddArray(numArray, numArray2, result, arrayLength);
            }
            break;

    }

}

void BuildArrayN(int option)
{
    int[] numArray = new int[TAM_MAX];


    Console.WriteLine("Build array");
    Console.Write("Write the lenght of the array please:");
    int lenghtArray = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < lenghtArray; i++)
    {
        Console.Write($"Give me the number {i + 1}:");
        numArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    WriteArrayF(numArray, lenghtArray);
    WriteArrayW(numArray, lenghtArray);
}

void WriteArrayF(int[] a, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {

        Console.Write($"{a[i]}");

        if (i < length-1)
        {

            Console.Write(",");

        }
    }
    Console.WriteLine("]");

}

void WriteArrayW(int[] a, int length)
{
   int i= 0;
   Console.Write("[");
   while (i < length)
    {
        Console.Write($"{a[i]}");
        if (i < length - 1)
        {
            Console.Write(",");
            
        }
        ++i;
    }

    Console.WriteLine("]");
    
}
void BuildArrayStringN(int option)
{
    string[] wordArray= new string[TAM_MAX];
    Console.WriteLine("Build an array of strings");
    Console.Write("Write the length please:");
    int length= Convert.ToInt32(Console.ReadLine());
    for (int i = 0;i< length; i++)
    {
        Console.Write($"Give me the word {i + 1}:");
        wordArray[i]= Console.ReadLine();    
    }
    WriteArrayString(wordArray, length);

}

void WriteArrayString(string[] w, int length)
{
    Console.Write('[');
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{w[i]}");
        if (i< length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
void ReadArray(int[] a, int length)
{
     
   

    
    for (int i = 0; i < length; i++)
    {

        Console.Write($"Give me the number {i + 1}: ");
        a[i] = Convert.ToInt32(Console.ReadLine());

    }
    WriteArrays(a, length);

}
    void WriteArrays(int[] numArray, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numArray[i]);
        if (i< length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]"); 
}

void AddArray(int[]n,int[]n2, int[] result, int length)
{
    
    for (int i = 0; i< length; i++)
    {         
        result[i] = n[i] + n2[i];
    }

    Console.Write("The result is: ");
    WriteArrays(result, length);
}