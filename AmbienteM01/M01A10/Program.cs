// usando DATETIME => para datas

int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;
Console.WriteLine("A data atual é dia " + dia + " do mês " + mes + " do ano " + ano);

int hora = DateTime.Now.Hour;
int min = DateTime.Now.Minute;
int seg = DateTime.Now.Second;
Console.WriteLine("A hora atual é " + hora + " hora(s) " + min + " minuto(s) e " + seg + " segundo(s)");
