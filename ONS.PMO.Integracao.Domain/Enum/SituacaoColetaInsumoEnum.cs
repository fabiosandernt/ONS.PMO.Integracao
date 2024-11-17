using System.ComponentModel;

namespace ONS.PMO.Integracao.Domain.Enum
{
    [Flags]
    public enum SituacaoColetaInsumoEnum
    {
        [Description("Não Iniciado")]
        NaoIniciado = 1,
        [Description("Em Andamento")]
        EmAndamento,
        Informado,
        Capturado,
        Aprovado,
        Rejeitado,
        [Description("Pré-Aprovado")]
        PreAprovado
    }
}
