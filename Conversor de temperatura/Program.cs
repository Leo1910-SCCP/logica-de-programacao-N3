//Conversão de Temperatura -> Difícil
//Crie um programa que peça ao usuário uma temperatura em graus Celsius.
//Converta para Fahrenheit usando a fórmula: F = (Cx9 / 5) + 32
//Exiba o resultado.




Console.WriteLine("CONVERSOR DE TEMPERATURA");
Console.WriteLine("Digite a temperatura em celsius");
double temperatura =double.Parse(Console.ReadLine());

Console.WriteLine("A sua temperatura em fahrenheit é "+ ((temperatura*9/5)+32 ));
