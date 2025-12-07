//ENTRADA
// idade: Inteiro

//PROCESSAMENTO
//  Escreva ("Informe sua Idade: ")
//  Leia (idade)

//SAÍDA
//  Se (idade >= 5 E idade <= 7) então
//     Escreva ("Sua Classificação: Infantil A")
//  Senão Se (idade >= 8 E idade <= 11) então
//     Escreva ("Sua Classificação: Infantil B")
//  Senão Se (idade >= 12 E idade <= 13) então
//     Escreva("Sua Classificação: Juvenil A")
//  Senão Se (idade >= 14 E idade <= 17) então
//     Escreva("Sua Classificação: Juvenil B")
//  Senão Se (idade >= 18) então
//     Escreva("Sua Classificação: Adulto") 

int idade;

Console.WriteLine("Informe sua Idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 5 & idade <= 7) 
{
    Console.WriteLine("Sua Classificação: Infantil A");
} else if (idade >= 8 & idade <= 11)
{
    Console.WriteLine("Sua Classificação: Infantil B");
} else if (idade >= 12 & idade <= 13)
{
    Console.WriteLine("Sua Classificação: Juvenil A");
} else if (idade >= 14 & idade <= 17)
{
    Console.WriteLine("Sua Classificação: Juvenil B");
} else if (idade >= 18)
{
    Console.WriteLine("Sua Classificação: Adulto");
}
