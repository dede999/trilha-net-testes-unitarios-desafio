using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        var texto = "Oh my god, they killed Kenny!";
        var resultadoEsperado = 29;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Assert
        Assert.True(_validacoes.ContemCaractere(texto, textoProcurado));
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Theory]
    [InlineData("procurado", true, System.StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Procurado", true, System.StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("PROCURADO", true, System.StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("procurado", true, System.StringComparison.InvariantCulture)]
    [InlineData("Procurado", false, System.StringComparison.InvariantCulture)]
    [InlineData("PROCURADO", false, System.StringComparison.InvariantCulture)]
    public void TextoDeveTerminarComAPalavraProcurado(
        string textoProcurado, bool esperado, System.StringComparison comparison)
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado, comparison);

        // Assert
        Assert.Equal(esperado, resultado);
    }
    
    [Theory]
    [InlineData("Começo", true, System.StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("começo", true, System.StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("COMEÇO", true, System.StringComparison.InvariantCultureIgnoreCase)]
    [InlineData("Começo", true, System.StringComparison.InvariantCulture)]
    [InlineData("começo", false, System.StringComparison.InvariantCulture)]
    [InlineData("COMEÇO", false, System.StringComparison.InvariantCulture)]
    public void TextoDeveComecarComAPalavraComeco(
        string textoProcurado, bool esperado, System.StringComparison comparison)
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";

        // Act
        var resultado = _validacoes.TextoComecaCom(texto, textoProcurado, comparison);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}
