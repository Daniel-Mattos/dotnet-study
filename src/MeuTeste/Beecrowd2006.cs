using System;

public class Beecrowd2006
{
	public static void Executar()
	{
		//Exercicio do beecrowd 2006 iniciante
		
		string? entrada = Console.ReadLine();
		string? entrada2 = Console.ReadLine();

		string[] numerosComoTexto = entrada2?.Split(' ') ?? Array.Empty<string>();

		Console.WriteLine(numerosComoTexto.Length);
		Console.WriteLine(entrada);
		Console.WriteLine(entrada2);
	}
}