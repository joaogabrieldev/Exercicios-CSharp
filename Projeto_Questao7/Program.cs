//ENTRADA
// numero1, numero2, numero3: real

//PROCESSAMENTO
// Escreva("Informe o número 1: ")
// Leia (numero1)
// Escreva("Informe o número 2: ")
// Leia (numero2)
//Escreva("Informe o número 3: ")
// Leia (numero3)

//SAÍDA
// Se (numero1 > numero2 E numero3) então
//   Escreva ($"O número {numero1} é o maior entre todos!")
// Senao Se (numero 2 > numero1 E numero3)
//   Escreva ($"O número {numero2} é o maior entre todos!")
// Senao
//   Escreva ($"O número {numero3} é o maior entre todos!")

double numero1, numero2, numero3;
Console.WriteLine("Informe o Número 1: ");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o Número 2: ");
numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o Número 3: ");
numero3 = Convert.ToDouble(Console.ReadLine());

if (numero1 > numero2 & numero1 > numero3)
{
    Console.WriteLine($"O número {numero1} é o maior entre todos!");
}
else if (numero2 > numero1 & numero2 > numero3)
{
    Console.WriteLine($"O número {numero2} é o maior entre todos!");
} else
{
    Console.WriteLine($"O número {numero3} é o maior entre todos!");
}
