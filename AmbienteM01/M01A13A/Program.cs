//Formatação de Strings Interpoladas em C# 

string nome = "Analu";
float sal = 3023.3234f;
int idade = 16;
int num = 13;
float valor = 4469.003f;

Console.WriteLine($"Muito prazer em te conhecer, {nome, 20}!!!");
//para completar o nome com espaços em branco até 20 caracteres (fica alinhado à direita)
Console.WriteLine($"Muito prazer em te conhecer, {nome, -20}!!!");
//para completar o nome com espaços em branco até 20 caracteres (fica alinhado à esquerda)
Console.WriteLine($"Muito prazer em te conhecer, {nome, 3}!!!");
//se a string extrapolar o número de caracteres solicitado, fica tudo normal sem alteração
Console.WriteLine($"O {nome, -10} ganha {sal,20:C3} por mês");
//exemplo com número ( :C = currency / :C3 = 3 casas decimais)
Console.WriteLine($"O {nome,-10} tem {idade, -5:D3} anos e ganha {sal,20:C3} por mês");
// :D = número inteiro / :D3 = número inteiro com 3 dígitos
Console.WriteLine($"O número foi {num:X}");
// :X = número hexadecimal
Console.WriteLine($"O valor foi {valor:E}");
// :E = notação científica
