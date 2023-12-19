// INTERPOLAÇÃO DE STRINGS

Console.Write("Qual é o seu nome? ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}! Tudo bem?");

int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;
Console.WriteLine($"Hoje é {dia} do mês {mes} do ano de {ano}");
