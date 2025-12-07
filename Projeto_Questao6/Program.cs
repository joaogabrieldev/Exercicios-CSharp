//ENTRADA
// numero1, numero2: real

//PROCESSAMENTO
// Escreva("Informe o número 1: ")
// Leia (numero1)
// Escreva("Informe o número 2: ")
// Leia (numero2)

//SAÍDA
// Se (numero1 > numero2) então
//   Escreva ($"{numero1} é maior que {numero2}!")
// Senao
//   Escreva ($"{numero2} é maior que {numero1}")  

double numero1, numero2;
Console.WriteLine("Informe o Número 1: ");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o Número 2: ");
numero2 = Convert.ToDouble(Console.ReadLine());
if (numero1 > numero2)
{
    Console.WriteLine($"{numero1} é maior que {numero2}!");
} else
{
    Console.WriteLine($"{numero2} é maior que {numero1}");
}
