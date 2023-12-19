// USANDO TEMPORIZADOR PARA ENVIO DE MENSAGENS

int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;
Console.Write("Hoje é dia ");
Thread.Sleep(1000);
Console.Write(dia);
Thread.Sleep(1000);
Console.Write(" do mês ");
Thread.Sleep(1000);
Console.Write(mes);
Console.Write(" do ano ");
Thread.Sleep(1000);
Console.Write(ano);
