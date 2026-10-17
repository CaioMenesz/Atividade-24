public class PlanoStreamingService
{
    public void ObterClassificacaoPorQualidade(int telasSimultaneas)

    {
        if (telasSimultaneas == 1)
        {
            Console.WriteLine("BÁSICO");
        }
        else if (telasSimultaneas == 2)
        {
            Console.WriteLine("PADRÃO");
        }
        else if (telasSimultaneas >= 4)
        {
            Console.WriteLine("PREMIUM");
        }
             
    }

    public void CalcularMensalidadeComDesconto(decimal valorBase, int mesesContratados)
    {
        if (mesesContratados >= 6 && mesesContratados < 12)
        {
            decimal resultadoDesconto = valorBase - (valorBase * 0.10M);
            Console.WriteLine($"Valor com desconto: {resultadoDesconto}");
        }
        else if (mesesContratados >= 12)
        {
            decimal resultadoDesconto = valorBase - (valorBase * 0.20M);
            Console.WriteLine($"Valor com desconto: {resultadoDesconto}");
        }
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