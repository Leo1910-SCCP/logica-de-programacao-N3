
using System.ComponentModel.Design;

Console.WriteLine("qual sua idade");

string Resposta  = Console.ReadLine();

int Idade = int.Parse(Resposta);

bool Valido = int.TryParse(Resposta, out Idade);



if (Valido)
{
 
    
    if (Idade >= 18)
            
     {   Console.WriteLine("Usuario maior de idade");   
     }
 
     else if (Idade <=0)
     {
        Console.WriteLine("Idade invalida"); 
     }   
     
    else 
    {
        Console.WriteLine("Usuario menor de idade");
    }
        





}
           
else 
        {
            Console.WriteLine("valor informado não é valido");

        }       
        












