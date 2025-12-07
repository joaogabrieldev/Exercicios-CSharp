// ENTRADA

//  numero, metadeNumero: real

// PROCESSAMENTO

// Escreva ("Informe um Número")
// Leia (numero)
// metadeNumero <- numero/2  

// SAÍDA

// Se(metadeNumero > 50) então
//     Escreva ("O metade do número informado é: " + metadeNumero)

//ENTRADA

double numero, metadeNumero;

//PROCESSAMENTO

Console.WriteLine("Informe um Número");
numero = Convert.ToDouble(Console.ReadLine());
metadeNumero = numero / 2;

//SAIDA

    if (metadeNumero > 50)
{
    Console.WriteLine($"O metade do número informado é: {metadeNumero}");
}