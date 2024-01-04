int ano;
Console.Write("Em que ano você nasceu? ");
int.TryParse(Console.ReadLine(), out ano);
Console.WriteLine("---------------------");
Console.WriteLine($"O ano atual é {DateTime.Now.Year}");
Console.WriteLine($"Se você nasceu em {ano}, vai ter {(DateTime.Now.Year) - ano} anos.");

//na resolução do professor, ele criou uma variável para o ano atual e outra variável para idade