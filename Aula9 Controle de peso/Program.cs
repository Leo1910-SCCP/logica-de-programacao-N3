//Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:
//A quantidade de pessoas com mais de 90 quilos;
//A média das idades das sete pessoas;





const int QTDPessoas = 7;

int Contadorpessoas90KG = 0;
int somaIdade = 0;


string EntradaUsuario;

for (int contador = 0; contador < QTDPessoas; contador++)
    {Console.WriteLine("Insira sua idade");
    EntradaUsuario = Console.ReadLine();
    int.TryParse(EntradaUsuario, out int idade);

    Console.WriteLine("Insira o seu peso");
    EntradaUsuario =Console.ReadLine();
    int.TryParse(EntradaUsuario,out int peso);

    somaIdade += idade;

    if (peso > 90)
    {
        Contadorpessoas90KG++;

    }

}


Console.WriteLine("a quantide de pessoas com mais de 90KG é " + Contadorpessoas90KG);
Console.WriteLine("A média de idade das pessoas é de " + (somaIdade/QTDPessoas));
