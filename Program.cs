
{
   
    {
        Console.Write("Digite um número: 15");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar");
        }
    }
}

