//ENTRADA
//   cargo, ajuste: caractere
//   salario, salarioAjuste: real  


//PROCESSAMENTO

// Escreva ("Informe seu Salário Atual: ")
// Leia (salario)
// Escreva ("Informe seu Cargo: ")
// Leia (cargo)


//SAIDA
//   Se (cargo == "Técnico" OU cargo == "Tecnico" OU cargo == "tecnico" OU cargo == "técnico") entao
//      ajuste = "15%";
//      salarioAjuste = salario + (15/100 * salario);
//      Escreva ($"O seu Salário Atual é de {salario}, entretanto, devido aos reajustes e devido ao seu cargo de {cargo}, seu salário ficou: {salarioAjuste}")      

//   Senao (cargo == "Gerente" OU cargo == "gerente")
//      ajuste = "13%";
//      salarioAjuste = salario + (13/100 * salario)
//      Escreva ($"O seu Salário Atual é de {salario}, entretanto, devido aos reajustes e devido ao seu cargo de {cargo}, seu salário ficou: {salarioAjuste}")   

//   Senao 
//      ajuste = "11%"
//      salarioAjuste = salario + (11/100 * salario)
//      Escreva ($"O seu Salário Atual é de {salario}, entretanto, devido aos reajustes e devido ao seu cargo de {cargo}, seu salário ficou: {salarioAjuste}")   


string cargo, ajuste;
double salario, salarioAjuste;



Console.WriteLine("Informe seu Salário Atual: ");
salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe seu Cargo: ");
cargo = Console.ReadLine();

if (cargo == "Técnico" || cargo == "Tecnico" || cargo == "tecnico" || cargo == "técnico") 
{    
     ajuste = "15%";
    salarioAjuste = salario + (15/100 * salario);
    Console.WriteLine($"O seu Salário Atual é de {salario}, entretanto, devido aos reajustes e devido ao seu cargo de {cargo}, seu salário ficou  {salarioAjuste} , com um ajuste de {ajuste}");

} else if(cargo == "Gerente" || cargo == "gerente")
{     
    ajuste = "13%";
    salarioAjuste = salario + (13 / 100 * salario);
    Console.WriteLine($"O seu Salário Atual é de {salario}, entretanto, devido aos reajustes e devido ao seu cargo de {cargo}, seu salário ficou {salarioAjuste}, com um ajuste de {ajuste}");

} else
{
    ajuste = "11%";
    salarioAjuste = salario + (11 / 100 * salario);
    Console.WriteLine($"O seu Salário Atual é de {salario}, entretanto, devido aos reajustes e devido ao seu cargo de {cargo}, seu salário ficou {salarioAjuste}, com um ajuste de {ajuste}"); 
}