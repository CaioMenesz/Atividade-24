namespace StreamingFlix.Tests;
using Xunit;
using StreamingFlix.App;

public class PlanoStreamingServiceTests
{
    [Theory]   

    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void ClassificacaoPlanos(int id, string planoEsperado)
    {
        var service = new PlanoStreamingService();

        string planoRetornado = service.ObterClassificacaoPorQualidade(id);
        

        Assert.NotNull(planoRetornado);
        Assert.Equal(planoEsperado, planoRetornado);
        
    }

    [Theory]

    [InlineData(50, 1, 50)] //(sem desconto)
    [InlineData(50, 6, 45)] //(10% de desconto)
    [InlineData(50, 12, 40)] //(20% de desconto)

    public void CalcularValorPlanoComDesconto(int valorBase, int mesesContratados, int resultadoEsperado)
    {
        var service = new PlanoStreamingService();

        decimal resultadoRetornado = service.CalcularMensalidadeComDesconto(valorBase, mesesContratados);

        Assert.True(resultadoRetornado > 0);
        Assert.Equal(resultadoEsperado, resultadoRetornado);
    }

    [Theory]

    [InlineData(20, false, true)]//(Maior de idade, sem restrição ->true)
    [InlineData(20, true, false)]//(Maior de idade, com restrição ->false)
    [InlineData(16, false, false)]//(Menor de idade -> false)


    public void PodeAcessarConteudoAdulto(int idade, bool controleParental, bool resultadoEsperado)
    {
        var service = new PlanoStreamingService();

        bool resultadoRetornado = service.PodeAcessarConteudoAdulto(idade, controleParental);
        
        Assert.True(resultadoEsperado == resultadoRetornado);

    }



    
}


