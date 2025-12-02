const string Senha_Correta = "12345";

Console.WriteLine("Insira sua idade");
bool IdadeValida = int.TryParse(Console.ReadLine(), out int idade);



if (!IdadeValida)
{
    Console.WriteLine("Idade invalida");
}
else
{
    int tentativas = 0;
    string senha;

    do
    {
         tentativas++;
         Console.WriteLine("Insira a senha: (tentativas " + tentativas + ")");
         senha = Console.ReadLine();
        if (senha == Senha_Correta&& idade >= 18)
        {
            Console.WriteLine("Acesso liberado...");
        }
        else
        {
            Console.WriteLine("acesso negado...");
        }
    }while (tentativas <3 && senha != Senha_Correta);
}
