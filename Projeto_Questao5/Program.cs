//ENTRADA
//  numero, verificadorPar: real    

//PROCESSAMENTO
//  Escreva ("Informe um Número: ")
//  Leia (numero)
//  verificadorPar <- Numero/2

//SAÍDA

// Se (verificadorPar mod 2 = 0) então
//    Escreva ($"O número {numero} é Par"); 

double numero, verificadorPar;
Console.WriteLine("Informe um Número: ");
numero = Convert.ToDouble(Console.ReadLine());
verificadorPar = numero % 2;
if (verificadorPar == 0)
{
    Console.WriteLine($"O número {numero} é Par");
}