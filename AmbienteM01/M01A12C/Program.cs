// INTERPOLAÇÃO COM NÚMEROS:

float sal = 0;
Console.Write("Informe o seu salário: ");
float.TryParse(Console.ReadLine(), out sal);
Console.WriteLine($"Você recebe {sal:C} por mês");
// :C significa "currency" => vai pegar a moeda local
