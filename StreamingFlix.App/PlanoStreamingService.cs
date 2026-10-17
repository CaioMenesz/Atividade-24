namespace StreamingFlix.App;
 
public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)

    {
        if (telasSimultaneas == 1) return "BÁSICO";
        if (telasSimultaneas == 2) return "PADRÃO";
        if (telasSimultaneas >= 4) return "PREMIUM";
        return "INDEFINIDO";
    }

    public decimal CalcularMensalidadeComDesconto(decimal valorBase, int mesesContratados)
    {
        if (mesesContratados >= 6 && mesesContratados < 12)
        {
            decimal resultadoDesconto = valorBase - (valorBase * 0.10M);
            return resultadoDesconto;
        }
        if (mesesContratados >= 12)
        {
            decimal resultadoDesconto = valorBase - (valorBase * 0.20M);
            return resultadoDesconto;
        }
        return valorBase;
    }

    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        if (idade >= 18 && controleParentalAtivo == false)
        {
            return true;
        }
        return false;
    }   
}
