namespace MeuTeste
{
	public class Calculadora
	{
		public static int Somar(int x, int y)
		{
			return x + y;
		}

		public static int Subtrair(int x, int y)
		{
			return x - y;
		}

		public static int Multiplicar(int x, int y)
		{
			return x * y;
		}

		public static string Divisao(int x, int y)
		{
			if (y == 0)
			{
				return "Não pode subtrair com zero";
			}
			return $"{x / y}";
		}
		public static double Potencia(int x, int y)
		{
			return Math.Pow(x, y);
		}
		public static string Seno(double angulo)
		{
			double radiano = angulo * Math.PI / 180;
			double x = Math.Sin(radiano);
			return $"O angulo: {angulo} possui o Seno: {Math.Round(x,4)}";
		}
		public static string Cos(double angulo)
		{
			double radiano = angulo * Math.PI / 180;
			double x = Math.Cos(radiano);
			return $"O angulo: {angulo} possui a Coseno: {Math.Round(x,4)}";
		}
		public static string Tangente(double angulo)
		{
			double radiano = angulo * Math.PI / 180;
			double x = Math.Tan(radiano);
			return $"O angulo: {angulo} possui a tangente: {Math.Round(x,4)}";
		}

		public static string RaizQuadrada(double x)
		{
			double raiz = Math.Sqrt(x);
			return $"A raiz quadrada de {x} é {raiz}";
		}
	}
}