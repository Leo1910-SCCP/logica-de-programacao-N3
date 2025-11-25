//Faça um programa que peça uma nota entre zero e dez.
//Mostre uma mensagem caso o valor seja inválido e
//continue pedindo até que o usuário informe um valor válido.

bool invalido= true;

 while (invalido)
{
    Console.WriteLine("Insira sua nota entre 0 e 10");
    string entradaUsuario = Console.ReadLine();
    bool valido = int.TryParse(entradaUsuario, out int nota);
    invalido = (!valido || nota < 0 || nota > 10);

    if (invalido) 
    {
       
        Console.WriteLine("Informe uma nota valida");
    }

        else
    {
      Console.WriteLine(nota + " é uma nota válida");
         
    }

}




   