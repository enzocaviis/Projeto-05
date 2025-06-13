string? msg1 = "Escolha uma das opções abaixo para converter o valor para:";

try
{
    Console.Clear();
    Console.WriteLine(msg1);
    Console.Write("1-Dolar\n2-Real\nOpção: ");
    int indice = int.Parse(Console.ReadLine());

    while (indice < 1 || indice > 2)
    {
        Console.Clear();
        Console.Write($"O indice não corresponde a 1 ou 2\n{msg1}\n1-Dolar\n2-Real\nOpção: ");
        indice = int.Parse(Console.ReadLine());
    }

    Converter moeda = (Converter)indice;

    switch (moeda)
    {

        case Converter.Dolar:
            Console.Clear();
            Console.Write("Quantos reais você quer converter para dolar: ");
            double real = double.Parse(Console.ReadLine());
            Console.Write("Qual é a cotação do dolar: ");
            double cotdoll1 = double.Parse(Console.ReadLine());
            double res1 = real / cotdoll1;
            if (real == 1)
            {
                Console.WriteLine($"{real} real para Dolar: {res1}");
            }
            else
            {
                Console.WriteLine($"{real} reais para Dolar: {res1}");
            }
            break;
        case Converter.Real:
            Console.Clear();
            Console.Write("Quantos dolares você quer converter para real: ");
            double doll = double.Parse(Console.ReadLine());
            Console.Write("Qual é a cotação do dolar: ");
            double cotdoll2 = double.Parse(Console.ReadLine());
            double res2 = doll * cotdoll2;
            if (doll == 1)
            {
                Console.WriteLine($"{doll} dolar para Real: {res2}");
            }
            else
            {
                Console.WriteLine($"{doll} dolares para Real: {res2}");
            }
            break;

    }
}
catch (Exception ex)
{
    Console.Clear();
    Console.WriteLine($"Informação recebida invalida\nErro: {ex.Message}");
}
enum Converter { Dolar = 1, Real }  