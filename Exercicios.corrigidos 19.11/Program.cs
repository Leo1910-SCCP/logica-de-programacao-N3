//Faça um programa que receba um número e,
//usando laços de repetição,
//calcule e mostre a tabuada desse número.



//Console.WriteLine("Insira um numero inteiro");

//string N1 = Console.ReadLine();

//bool Valido = int.TryParse(N1, out int numero);

//if (Valido)
//{
//    int contador = 1;
//    while (contador <= 10  )
//    {
//        Console.WriteLine(contador + " * " + numero + " = " + (contador * numero));
//        contador++;
//    }

//}
//else
//{
//   Console.WriteLine("O valor inserido não é valido");
//}

//EXEMPLO com DO



//Console.WriteLine("Insira um numero inteiro");

//string N1 = Console.ReadLine();

//bool Valido = int.TryParse(N1, out int numero);

//if (Valido)
//{
//    int contador = 1;
//    do
//    {
//        Console.WriteLine(contador + " * " + numero + " = " + (contador * numero));
//        contador++;
//    } while (contador <= 10);

//}
//else
//{
//    Console.WriteLine("O valor inserido não é valido");
//}





//EXEMPLO COM FOR   






Console.WriteLine("Insira um numero inteiro");

string N1 = Console.ReadLine();

bool Valido = int.TryParse(N1, out int numero);

if (Valido)
{
    for (int contador = 1;  contador <= 10; contador++)   
    {
        Console.WriteLine(contador + " * " + numero + " = " + (contador * numero));
        
    } 

}
else
{
    Console.WriteLine("O valor inserido não é valido");
}



