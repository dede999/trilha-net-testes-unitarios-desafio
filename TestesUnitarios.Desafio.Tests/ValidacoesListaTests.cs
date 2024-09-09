using TestesUnitarios.Desafio.Console.Services;
using TestesUnitarios.Desafio.Tests.Helper;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private readonly ValidacoesLista _validacoes = new ValidacoesLista();
    private readonly ValidationList _validationList = new ValidationList(6);

    [Fact]
    public void NegativeNumbersShouldBeRemoved()
    {
        // Arrange
        var resultadoEsperado = _validationList.NonNegativeList;

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(_validationList.OriginalList);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void BiggestNumberShouldBeInList()
    {
        // Arrange
        var numeroParaProcurar = _validationList.Biggest;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(
            _validationList.OriginalList, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NumberLesserThanSmallestShouldNotBeInList()
    {
        // Arrange
        var numeroParaProcurar = _validationList.Smallest - 1;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(
            _validationList.OriginalList, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void ListElementsShouldBeMultiplied()
    {
        // Arrange
        var resultadoEsperado = _validationList.MultipliedList;

        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(
            _validationList.OriginalList, _validationList.MultiplicationFactor);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ShouldReturnTheBiggestNumberInTheList()
    {
        // Arrange
        var lista = _validationList.OriginalList;

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(_validationList.Biggest, resultado);
    }

    [Fact]
    public void ShouldReturnTheSmallestNumber()
    {
        // Arrange
        var lista = _validationList.OriginalList;

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(_validationList.Smallest, resultado);
    }
    
    [Fact]
    public void ShouldReturnTheSumOfAllNumbers()
    {
        // Arrange
        var lista = _validationList.OriginalList;
        var resultadoEsperado = _validationList.Sum;

        // Act
        var resultado = _validacoes.SomarNumerosLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Fact]
    public void ShouldReturnTheAverageOfAllNumbers()
    {
        // Arrange
        var lista = _validationList.OriginalList;
        var resultadoEsperado = _validationList.Average;

        // Act
        var resultado = _validacoes.CalcularMediaLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Fact]
    public void ShouldReturnTheProductOfAllNumbers()
    {
        // Arrange
        var lista = _validationList.OriginalList;
        var resultadoEsperado = _validationList.Product;

        // Act
        var resultado = _validacoes.CalcularProdutoLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
