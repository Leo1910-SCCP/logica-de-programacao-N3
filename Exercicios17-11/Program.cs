

Console.WriteLine("VOTAÇÃO");
int Voto;
int azul = 0;
int roxo = 0;
int preto = 0;
int branco = 0;
int vermelho = 0;
Console.WriteLine("Escreva 0 para votar no azul");
Console.WriteLine("1 Pro Roxo");
Console.WriteLine("2 pro preto");
Console.WriteLine("3 pro branco");
Console.WriteLine("4 pro vermelho");

Voto = int.Parse(Console.ReadLine());


switch (Voto)
{
  case 0:
        azul++;
        Console.WriteLine("Você votou no azul");

        break;
    case 1:
        roxo++;
        Console.WriteLine("Voce votou no roxo");
        break;
    case 2:
        preto++;
        Console.WriteLine("Voce votou no preto");
        break;
    case 3:
        branco++;
        Console.WriteLine("Voce votou no branco");
        break;
    case 4:
        vermelho++;
        Console.WriteLine("Voce votou no vermelho");
        break;
    default:
        Console.WriteLine("Voto invalido");
        break;

}

Voto = int.Parse(Console.ReadLine());

switch (Voto)
{
    case 0:
        azul++;
        Console.WriteLine("Você votou no azul");

        break;
    case 1:
        roxo++;
        Console.WriteLine("Voce votou no roxo");
        break;
    case 2:
        preto++;
        Console.WriteLine("Voce votou no preto");
        break;
    case 3:
        branco++;
        Console.WriteLine("Voce votou no branco");
        break;
    case 4:
        vermelho++;
        Console.WriteLine("Voce votou no vermelho");
        break;
    default:
        Console.WriteLine("Voto invalido");
        break;

}
Voto = int.Parse(Console.ReadLine());


switch (Voto)
{
    case 0:
        azul++;
        Console.WriteLine("Você votou no azul");

        break;
    case 1:
        roxo++;
        Console.WriteLine("Voce votou no roxo");
        break;
    case 2:
        preto++;
        Console.WriteLine("Voce votou no preto");
        break;
    case 3:
        branco++;
        Console.WriteLine("Voce votou no branco");
        break;
    case 4:
        vermelho++;
        Console.WriteLine("Voce votou no vermelho");
        break;
    default:
        Console.WriteLine("Voto invalido");
        break;

}
Voto = int.Parse(Console.ReadLine());

switch (Voto)
{
    case 0:
        azul++;
        Console.WriteLine("Você votou no azul");

        break;
    case 1:
        roxo++;
        Console.WriteLine("Voce votou no roxo");
        break;
    case 2:
        preto++;
        Console.WriteLine("Voce votou no preto");
        break;
    case 3:
        branco++;
        Console.WriteLine("Voce votou no branco");
        break;
    case 4:
        vermelho++;
        Console.WriteLine("Voce votou no vermelho");
        break;
    default:
        Console.WriteLine("Voto invalido");
        break;

}
Voto = int.Parse(Console.ReadLine());

switch (Voto)
{
    case 0:
        azul++;
        Console.WriteLine("Você votou no azul");

        break;
    case 1:
        roxo++;
        Console.WriteLine("Voce votou no roxo");
        break;
    case 2:
        preto++;
        Console.WriteLine("Voce votou no preto");
        break;
    case 3:
        branco++;
        Console.WriteLine("Voce votou no branco");
        break;
    case 4:
        vermelho++;
        Console.WriteLine("Voce votou no vermelho");
        break;
    default:
        Console.WriteLine("Voto invalido");
        break;

}
Voto = int.Parse(Console.ReadLine());

switch (Voto)
{
    case 0:
        azul++;
        Console.WriteLine("Você votou no azul");

        break;
    case 1:
        roxo++;
        Console.WriteLine("Voce votou no roxo");
        break;
    case 2:
        preto++;
        Console.WriteLine("Voce votou no preto");
        break;
    case 3:
        branco++;
        Console.WriteLine("Voce votou no branco");
        break;
    case 4:
        vermelho++;
        Console.WriteLine("Voce votou no vermelho");
        break;
    default:
        Console.WriteLine("Voto invalido");
        break;

}



int mVotos = azul;
string Venc = "azul";

if (roxo > mVotos)
{
    Venc = "Roxo";
    mVotos = roxo;

}
 
if (preto > mVotos) 
{
mVotos = preto;
    Venc = "preto";

}
    
if (branco > mVotos)
{
    mVotos = branco;
    Venc = "branco";
}  

if (vermelho > mVotos)
{
mVotos = vermelho;
    Venc = "Vermelho";
}
    






Console.WriteLine("O vencedor é " + Venc);


