using System.ComponentModel;

namespace ONS.PMO.Integracao.Domain.Enum
{
    [Flags]
    public enum SituacaoSemanaOperativaEnum
    {
        [Description("Configuração")]
        Configuracao = 1,
        [Description("Coleta de dados")]
        ColetaDados,
        [Description("Geração de blocos")]
        GeracaoBlocos,
        [Description("Convergência CCEE")]
        ConvergenciaCCEE,
        [Description("Publicado")]
        Publicado,
        [Description("Convergência CCEE")]
        PLDConvergido
    }
}
