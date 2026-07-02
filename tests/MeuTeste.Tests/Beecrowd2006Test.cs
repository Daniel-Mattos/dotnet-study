namespace MeuTeste.Tests;

public class Beecrowd2006Tests
{
    [Theory]
    [InlineData("1\n1 2 3 2 1", "2")]
    [InlineData("3\n4 1 1 2 1", "0")]
    public void Executar_DeveContarQuantidadeCorretaDeAcertos(string entradasSimuladas, string resultadoEsperado)
    {
        using (var textoDigitado = new StringReader(entradasSimuladas))
        using (var telaConsole = new StringWriter())
        {
            Console.SetIn(textoDigitado);
            Console.SetOut(telaConsole);

            Beecrowd2006.Executar();

            string resultadoReal = telaConsole.ToString().Trim();

            Assert.Equal(resultadoEsperado, resultadoReal);
        }
    }
}