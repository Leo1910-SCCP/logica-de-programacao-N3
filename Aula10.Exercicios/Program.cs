int senha = 12345;
int senha2 = 0;
Console.WriteLine("Qual sua idade");
int idade = int.Parse(Console.ReadLine());



bool MaiorIdade = idade > 17;

 if (idade > 17)
{
    for (int chances = 4; chances > 0; chances--)
    {
        Console.WriteLine("Qual é a senha");
        senha2 = int.Parse(Console.ReadLine());
            if (senha == senha2)
        {
            Console.WriteLine("Parabens você acertou a senha");
        }
            else
        {
            Console.WriteLine("Senha errada vc tem mais " + chances + "tentativas");

        }



    }














}  
else
    {
        Console.WriteLine("Você é muito novo pra isso");
    }



    





