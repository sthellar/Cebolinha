// See https://aka.ms/new-console-templ ate for more information
Console.WriteLine("Seja bem vindo usuário!");
Console.Write("Digite uma frase: ");

string Frase = Console.ReadLine()!;
string NovaFrase = Frase.Replace("r", "l");  

Console.WriteLine(NovaFrase);