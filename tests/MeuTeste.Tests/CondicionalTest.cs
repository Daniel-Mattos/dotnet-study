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
}
