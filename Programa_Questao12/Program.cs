//ENTRADA
//salarioLiquido,salario, ImpostoDeRenda: real
//porcentoImpostoDeRenda = Caracter

//PROCESSAMENTO
// Escreva ("Informe o Valor do seu Salário: ")
// Leia (salario)

// salarioLiquido <- salario * (ImpostoDeRenda)

// Se (salario <= 1200.99) então
//    ImpostoDeRenda <- '0%'
//    salarioLiquido <- salario * 1        

// Senao Se (salario > 1201.00 & salario < 2500.99) entao 
//          ImpostoDeRenda <- 5/100
//          porcentoImpostoDeRenda <- '5%'

// Senao Se (salario > 2501.00 & salario < 4000.99) entao 
//          ImpostoDeRenda <- 8/100
//      
//          porcentoImpostoDeRenda <- '8%'

// Senao Se (salario > 4001.00 & salario < 7000.99) entao 
//          ImpostoDeRenda <- 12/100
//          porcentoImpostoDeRenda <- '12%'

// Senao Se (salario > 7001.00) entao 
//          ImpostoDeRenda <- 27.5/100
//          porcentoImpostoDeRenda <- '27.5%'            


//SAÍDA

//Escreva ($"Seu Salário Liquido ficou {salarioLiquido}, e o Valor do Imposto de Renda, já descontado do seu Salário, foi {porcentoImpostoDeRenda}.")


double salarioLiquido, salario, ImpostoDeRenda;
string porcentoImpostoDeRenda;

Console.WriteLine("Informe o Valor do seu Salário: ");
salario = Convert.ToDouble(Console.ReadLine());

if (salario <= 1200.99)
{
    porcentoImpostoDeRenda = "0%";
    salarioLiquido = salario * 1;
    Console.WriteLine($"Seu Salário Liquido ficou {salarioLiquido}, e o Valor do Imposto de Renda, já descontado do seu Salário, foi {porcentoImpostoDeRenda}.");

} else if (salario > 1201.00 & salario < 2500.99)
{
    ImpostoDeRenda = 5 / 100;
    porcentoImpostoDeRenda = "5%";
    salarioLiquido = ImpostoDeRenda * salario;
    Console.WriteLine($"Seu Salário Liquido ficou {salarioLiquido}, e o Valor do Imposto de Renda, já descontado do seu Salário, foi {porcentoImpostoDeRenda}.");

} else if (salario > 2501.00 & salario < 4000.99) 
{
    ImpostoDeRenda = 8 / 100;
    porcentoImpostoDeRenda = "8%";
    salarioLiquido = ImpostoDeRenda * salario;
    Console.WriteLine($"Seu Salário Liquido ficou {salarioLiquido}, e o Valor do Imposto de Renda, já descontado do seu Salário, foi {porcentoImpostoDeRenda}.");

} else if (salario > 4001.00 & salario < 7000.99)
{
    ImpostoDeRenda = 12 / 100;
    porcentoImpostoDeRenda = "12%";
    salarioLiquido = ImpostoDeRenda * salario;
    Console.WriteLine($"Seu Salário Liquido ficou {salarioLiquido}, e o Valor do Imposto de Renda, já descontado do seu Salário, foi {porcentoImpostoDeRenda}.");

} else if (salario > 7001.00)
{
    ImpostoDeRenda = 27.5 / 100;
    porcentoImpostoDeRenda = "27.5%";
    salarioLiquido = ImpostoDeRenda * salario;
    Console.WriteLine($"Seu Salário Liquido ficou {salarioLiquido}, e o Valor do Imposto de Renda, já descontado do seu Salário, foi {porcentoImpostoDeRenda}.");
}





