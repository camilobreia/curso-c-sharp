// Conversão de Tipos em Constantes em C#

// CONVERSÃO IMPLÍCITA int => float

/* int a = 8;
float b = a;
Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());*/

// CONVERSÃO EXPLÍCITA float => int

/*float a = 8.75f;
int b = (int)a;
Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());*/

// CONVERSÃO POR CLASSES AUXILIARES:

float a = 8.75f;
int b = Convert.ToInt16(a);
Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());
