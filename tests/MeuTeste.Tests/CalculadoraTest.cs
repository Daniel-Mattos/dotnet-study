namespace MeuTeste.Tests;

public class CalculadoraTest
{
	[Fact]
	public void VerificarSoma()
	{
		// Act
		int resultado = Calculadora.Somar(10,20);

		// Assert
		Assert.Equal(30, resultado);
	}
	[Fact]
	public void VerificarSubtrair()
	{
		// Act
		int resultado = Calculadora.Subtrair(10,2);

		// Assert
		Assert.Equal(8, resultado);
	}
	[Fact]
	public void VerificarMult()
	{
		// Act
		int resultado = Calculadora.Multiplicar(10,20);

		// Assert
		Assert.Equal(200, resultado);
	}

	[Fact]
	public void VerificarDiv()
	{
		// Act
		string resultado = Calculadora.Divisao(10,2);

		// Assert
		Assert.Equal("5", resultado);
	}
	[Fact]
	public void VerificarDivComZero()
	{
		// Act
		string resultado = Calculadora.Divisao(10,0);

		// Assert
		Assert.Equal("Não pode subtrair com zero", resultado);
	}
	[Fact]
	public void VerificarPotencia()
	{
		// Act
		double resultado = Calculadora.Potencia(10,2);

		// Assert
		Assert.Equal(100, resultado);
	}
}