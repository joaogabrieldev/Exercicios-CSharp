//ENTRADA
//  numero, QuintaParteNumero: real    

//PROCESSAMENTO
//  Escreva ("Informe um Número: ")
//  Leia (numero)
//  QuintaParteNumero <- numero/5

//SAÍDA

// Se (QuintaParteNumero < 50 OU QuintaParteNumero > 1000)
//    Escreva ($"A quinta de {numero} é: {QuintaParteNumero} "); 

double numero, QuintaParteNumero;
Console.WriteLine("Informe um Número: ");
numero = Convert.ToDouble(Console.ReadLine());
QuintaParteNumero = numero / 5;
if (numero < 50 || numero > 1000)
{
    Console.WriteLine($"A quinta de {numero} é: {QuintaParteNumero}");
}