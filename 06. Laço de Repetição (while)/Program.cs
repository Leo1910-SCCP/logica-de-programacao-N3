
Console.WriteLine("Digite um numero");
int num = int.Parse(Console.ReadLine());
int contador = 0;
while (num > 0)
{
    Console.WriteLine("Digite outro número");
    num = int.Parse(Console.ReadLine());
    contador++;
}
Console.WriteLine("Você digitou " + contador + " Números");