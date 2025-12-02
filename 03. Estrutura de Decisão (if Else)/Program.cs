Console.WriteLine("Digite um numero inteiro");
int num = int.Parse(Console.ReadLine());

bool mult3 = num % 3 == 0;
bool mult5 = num % 5 == 0;

if (mult3 && mult5)
{
    Console.WriteLine("Esse número é múltiplo de 3 e de 5");
}
else if (mult3 && !mult5 )
{
    Console.WriteLine("Esse número é múltiplo de 3");
}
else if (mult5 && !mult3)
{
    Console.WriteLine("Esse número é múltiplo de 5");
}
else
{
    Console.WriteLine("O número não é múltiplo nem de 3 e nem de 5 ou não é valido");
}
