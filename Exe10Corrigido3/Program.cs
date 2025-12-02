double valor=-1, total = 0;
const string CUPOM10 = "CUPOM10";


while (valor!= 0)
{
    Console.WriteLine("Insira o valor do produto");
    valor = double.Parse(Console.ReadLine());

    if (valor > 0)
    {
        total += valor;
    }
}

Console.WriteLine("Insira o cupom de desconto");
string cupom = Console.ReadLine();

if (cupom != CUPOM10|| total > 100)
{

    Console.WriteLine("O valor total com 10% de desconto é " + total * 0.9);
}
else
{
    Console.WriteLine("O valor final é R$ " +  total);
}



