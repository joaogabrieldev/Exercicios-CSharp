//ENTRADA
// numero, dobroNumero: real    


//PROCESSAMENTO
//  Escreva("Informe um Número: ")
//  Leia(numero)
//  dobroNumero <- numero * 2  

//SAIDA

// Se (dobroNumero > 90 E dobroNumero < 100) então
//    Escreva ("O metade do número informado é: " + dobroNumero)

double numero, dobroNumero;
Console.WriteLine("Informe um Número: ");
numero = Convert.ToDouble(Console.ReadLine());
dobroNumero = numero * 2;
if (dobroNumero > 90 && dobroNumero < 100)
{
    Console.WriteLine("O metade do número informado é: " + dobroNumero);
}