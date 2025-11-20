const string Amarelo = "Amarelo";
const string Azul = "Azul";
const string Verde = "Verde";
const string Abs = "";

string voto;

int Votoamarelo = 0;
int Votoazul = 0;
int VotoVerde = 0;
int abs = 0;

Console.WriteLine("Escolha a cor que quer votar\nAmarelo\nAzul\nVerde");

voto = (Console.ReadLine());


switch (voto)
{
    case Amarelo:
        Votoamarelo++;
        break;
    case Azul:
        Votoazul++;
        break;
    case Verde:
        VotoVerde++;
        break;
   default:
        abs++;
            break;
        

}
voto = (Console.ReadLine());


switch (voto)
{
    case Amarelo:
        Votoamarelo++;
        break;
    case Azul:
        Votoazul++;
        break;
    case Verde:
        VotoVerde++;
        break;
    default:
        abs++;
        break;


}
voto = (Console.ReadLine());


switch (voto)
{
    case Amarelo:
        Votoamarelo++;
        break;
    case Azul:
        Votoazul++;
        break;
    case Verde:
        VotoVerde++;
        break;
    default:
        abs++;
        break;


}
Console.WriteLine("Escolha"
voto = (Console.ReadLine());


switch (voto)
{
    case Amarelo:
        Votoamarelo++;
        break;
    case Azul:
        Votoazul++;
        break;
    case Verde:
        VotoVerde++;
        break;
    default:
        abs++;
        break;


}








int Vencedor  = 0;

if (Vencedor < Votoamarelo)
{
    Vencedor = Votoamarelo;
    Console.WriteLine("O vencedor é o amarelo");
}
if (Vencedor < Votoazul)
{
    Vencedor = Votoazul;
    Console.WriteLine("O vencedor é o Azul");
}
if (Vencedor < VotoVerde)
{
    Vencedor = VotoVerde;
    Console.WriteLine("O vencedor é o Verde");
}
if (Vencedor < abs)
{
    Vencedor = abs;
    Console.WriteLine("O vencedor é o amarelo");
}
