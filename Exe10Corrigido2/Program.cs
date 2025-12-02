Console.WriteLine("Insira um numero inteiro e positivo");
bool inteiro = int.TryParse(Console.ReadLine(), out int numero);



if (inteiro && numero > 0)
{
    for (int contador =1; contador <= numero; contador++)
    {
        bool par = contador % 2 == 0;
        bool mult5 = contador % 5 == 0;

        if (par && mult5)
        {
            
            Console.WriteLine(contador + " é par e multiplo de 5");



        }
        else if (par && !mult5) 
        {
            Console.WriteLine(contador+ " é par");
        }
        else
        {
            Console.WriteLine(contador + " é impar");
        }
        
    }
}
else
{
    Console.WriteLine("o numero informado não é valido");
}