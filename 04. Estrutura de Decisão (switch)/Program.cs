
Console.WriteLine("Descubra o dia da semana");
Console.WriteLine("Digite um numero de 1 a 7");
int dia = int.Parse(Console.ReadLine());



switch (dia)
{
    case 1:
        Console.WriteLine("O primeiro dia da semana é domingo");
        break;
    case 2:
        Console.WriteLine("O segundo dia da semana é segunda-feira");
        break;

    case 3:
        Console.WriteLine("O terceiro dia da semana é terça-feira");
        break;
    case 4:
        Console.WriteLine("O quarto dia da semana é quarta-feira");
        break;

    case 5:
        Console.WriteLine("O quinto dia da semana é quinta-feira");
        break;
    case 6:
        Console.WriteLine("O sexto dia da semana é sexta-feira");
        break;
  
    case 7:
        Console.WriteLine("O ultimo dia da semana é sabado");
        break;
    default:
        Console.WriteLine(dia + " não é um dia da semana");
        break;
}


