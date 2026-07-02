namespace MeuTeste.Tests;

public class CondicionalTest
{
    [Fact]
    public void VerificarNumero_QuandoPositivo_DeveRetornarMensagemCorreta()
    {
        // Act
        string resultado = Condicional.VerificarNumero(5);

        // Assert
        Assert.Equal("5 é um número posistivo", resultado);
    }
    [Fact]
    public void VerificarNumero_QuandoNegativo_DeveRetornarMensagemCorreta()
    {
        // Act
        string resultado = Condicional.VerificarNumero(-1);

        // Assert
        Assert.Equal("-1 não é um número posistivo", resultado);
    }

    [Fact]
    public void VerificarNumero_QuandoNeutro_DeveRetornarMensagemCorreta()
    {
        // Act
        string resultado = Condicional.VerificarNumero(0);

        // Assert
        Assert.Equal("0 é um número neutro", resultado);
    }
}
