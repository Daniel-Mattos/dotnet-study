namespace MeuTeste
{
	public class Beecrowd2006
	{
		public static void Executar()
		{
			//Exercicio do beecrowd 2006 iniciante

			string entrada = Console.ReadLine();
			string entrada2 = Console.ReadLine();
			int resultado = 0;

			string[] numerosComoTexto = entrada2.Split(' ');

			for (int i = 0; i < numerosComoTexto.Length; i++)
			{
				if (numerosComoTexto[i] == entrada)
					resultado += 1;
			}
			Console.WriteLine(resultado);
		}
	}
}