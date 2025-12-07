//ENTRADA
//  numero, SextuploNumero: real    

//PROCESSAMENTO
//  Escreva ("Informe um Número: ")
//  Leia (numero)
//  Sextuplo <- numero * 6

//SAÍDA

// Se (Sextuplo > 90)
//    Escreva ($"O Sextuplo {numero} é: {Sextuplo}"); 

double numero, sextuplo;
Console.WriteLine("Informe um Número: ");
numero = Convert.ToDouble(Console.ReadLine());
sextuplo = numero * 6;
if (sextuplo > 90)
{
    Console.WriteLine($"A quinta de {numero} é: {sextuplo}");
}