namespace MeuTeste.Tests;

public class SwitchCaseTest
{
	[Fact]
	public void Verificar_letra_vogal_correta()
	{
		string resultado = SwitchCase.VerificarVogal("a");

		Assert.Equal("a é uma vogal",resultado);
	}

	[Fact]
	public void Verificar_letra_vogal_incorreta()
	{
		string resultado = SwitchCase.VerificarVogal("s");

		Assert.Equal("s não é uma vogal",resultado);
	}
}