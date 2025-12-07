//ENTRADA
// numero: inteiro
// diaSemana: Caractere

//PROCESSAMENTO

//Escreva ("Informe um número de 1 a 7: ")
//Leia (numero)


//SAÍDA
// Se (numero == 1) entao
//    diaSemana = "Domingo";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} "); 

// Senao Se (numero == 2) entao
//    diaSemana = "Segunda";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} "); 

// Senao Se (numero == 3) entao
//    diaSemana = "Terça";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} "); 

// Senao Se (numero == 4) entao
//    diaSemana = "Quarta";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} "); 

// Senao Se (numero == 5) entao
//    diaSemana = "Quinta";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} "); 

// Senao Se (numero == 6) entao
//    diaSemana = "Sexta";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} "); 

// Senao Se (numero == 7) entao
//    diaSemana = "Sábado";
//    Escreva ($"O Dia que coincide com o número é: {diaSemana} ");   

// Senao Se (numero > 7) entao
//    Escreva ("Número Inválido");  

int numero;
string diaSemana;

Console.WriteLine("Informe um número de 1 a 7: ");
numero = Convert.ToInt32(Console.ReadLine());


if (numero == 1)
{
    diaSemana = "Domingo";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

} else if(numero == 2)
{
    diaSemana = "Segunda";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

} else if (numero == 3)
{
    diaSemana = "Terça";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

} else if (numero == 4)
{
    diaSemana = "Quarta";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

}
else if (numero == 5)
{
    diaSemana = "Quinta";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

}
else if (numero == 6)
{
    diaSemana = "Sexta";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

}
else if (numero == 7)
{
    diaSemana = "Sábado";
    Console.WriteLine($"O Dia que Coincide com o número é: {diaSemana} ");

} else if(numero > 7) 
{
   Console.WriteLine("Número Inválido");

}
  


