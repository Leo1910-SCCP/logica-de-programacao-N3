//EXERCICIO 1
// Faça um programa que receba um número e, usando laços de repetição, calcule e mostre a tabuada desse número.


//for (int cont = 0; cont < 60; cont++)
//{ 
//Console.WriteLine("Digite um numero para ver sua tabuada");
//int num = int.Parse(Console.ReadLine());




//Console.WriteLine("A Tabuada do "+num+ " é");


//    Console.WriteLine(num+ "*1="+num*1 );
//    Console.WriteLine(num + "*2=" + num * 2);
//    Console.WriteLine(num + "*3=" + num * 3);
//    Console.WriteLine(num + "*4=" + num * 4);
//    Console.WriteLine(num + "*5=" + num * 5);
//    Console.WriteLine(num + "*6=" + num * 6);
//    Console.WriteLine(num + "*7=" + num * 7);
//    Console.WriteLine(num + "*8=" + num * 8);
//    Console.WriteLine(num + "*9=" + num * 9);
//    Console.WriteLine(num + "*10=" + num * 10);


//}

//EXERCICIO 2
//Validação de Nota: Faça um programa que peça uma nota entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue
//pedindo até que o usuário informe um valor válido.


//    Console.WriteLine("Escreva uma nota entre 0 e 10");
//    int nota = int.Parse(Console.ReadLine());


//while (nota >= 11)
//{
//    Console.WriteLine("Escreva uma nota válida");
//     nota = int.Parse(Console.ReadLine());


//}
//Console.WriteLine("Sua nota é "+nota );

//EXERCICIO 3
//Controle de peso: Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:
//A quantidade de pessoas com mais de 90 quilos;
//A média das idades das sete pessoas;

Console.WriteLine("Qual seu peso?");
    double peso1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual sua idade");
    double idade = double.Parse(Console.ReadLine());

for (int cont = 0; cont < 1; cont++)
{

    Console.WriteLine("Qual seu peso?");
    peso1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual sua idade");
    idade = int.Parse(Console.ReadLine());

}

Console.WriteLine("A média de idade das sete pessoas são "+idade / 2+" anos");

