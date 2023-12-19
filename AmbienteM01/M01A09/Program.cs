// GERADOR DE NÚMEROS ALEATÓRIOS:

Random gerador =  new Random(); 
// gerador é o nome do objeto que criei da classe Random
//new é um comando instanciador (gera um novo método)
//Random() chamada ao método construtor

int n1 = gerador.Next();
Console.WriteLine("Acabei de gerar um número: " + n1);
int n2 = gerador.Next(10); //número de 0 à 10
Console.WriteLine("Agora gerei um número aleatório de 0 à 9: " + n2);
int n3 = gerador.Next(5, 20); //número entre 5 e 19 (nunca vai gerar o último número)
Console.WriteLine("Agora um número entre 5 e 19: " + n3);

