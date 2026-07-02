namespace MeuTeste.Tests
{
	[Collection("Testes de Console Não Paralelos")]
	public class LacoTests
	{
		[Fact]
		public void Verificar_Tabuada()
		{
			var saidaOriginal = Console.Out;
			int numero = 2;

			using (StringWriter sw = new StringWriter())
			{
				Console.SetOut(sw);

				Laco.Tabuada(numero);

				string resultadoObtido = sw.ToString();
				
				Console.SetOut(saidaOriginal);

				Assert.Contains("2 X 1 = 2", resultadoObtido);
				Assert.Contains("2 X 5 = 10", resultadoObtido);
				Assert.Contains("2 X 10 = 20", resultadoObtido);
			}
		}
	}
}