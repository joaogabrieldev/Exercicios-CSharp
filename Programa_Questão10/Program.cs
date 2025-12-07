//ENTRADA
// nota1, nota2, media: real

//PROCESSAMENTO
//  Escreva ("Informe a nota 1: ")
//  Leia (nota1)
//  Escreva ("Informe a nota 2: ")
//  Leia (nota2)
//  media <- (nota1 + nota2)/2

//SAIDA
//  Se (media > 7.0) então
//     Escreva ("Aluno Aprovado")
//  Senão Se (media == 7.0) então
//     Escreva ("Aluno em Recuperação")
//  Senão Se (media < 7.0) então
//     Escreva ("Aluno Reprovado")



double nota1, nota2, media;

Console.WriteLine("Informe a nota 1: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a nota 2: ");
nota2 = Convert.ToDouble(Console.ReadLine());
media = (nota1 + nota2) / 2;

if (media > 7.0)
{
    Console.WriteLine("Aluno Aprovado");
} else if (media == 7.0)
{
    Console.WriteLine("Aluno em Recuperação");
} else if (media < 7.0)
{
    Console.WriteLine("Aluno Reprovado");
}



