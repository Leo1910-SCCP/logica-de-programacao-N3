const int CINCO = 5;
string [] nomes = new string [CINCO];


for (int i = 0; i < CINCO; i++)
{
    Console.WriteLine("Insira um nome:");
    nomes[i] = Console.ReadLine();
}

for (int i = 0;i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}