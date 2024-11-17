using System;
using System.ComponentModel;

namespace ONS.PMO.Integracao.Domain.Enum
{
    public enum ParametroEnum
    {
        [Description("CODIGO_AGENTE_ONS")]
        CodigoAgenteONS = 1,

        [Description("DIA_REUNIAO_PMO")]
        DiaReuniaoPMO = 2,

        [Description("DIA_REUNIAO_REVISAO")]
        DiaReuniaoRevisao = 3,

        [Description("MENSAGEM_ABERTURA_COLETA")]
        MensagemAberturaColeta = 4,

        [Description("MENSAGEM_REJEICAO_COLETA")]
        MensagemRejeicaoColeta = 5,

        [Description("NOME_PERFIL_GMC_1")]
        NomePerfilGmc1 = 6,

        [Description("NOME_PERFIL_GPD_1")]
        NomePerfilGPD1 = 7,

        [Description("NOME_PERFIL_GPD_2")]
        NomePerfilGPD2 = 8,

        [Description("NOME_PERFIL_GPD_3")]
        NomePerfilGPD3 = 9,

        [Description("NOME_PERFIL_GPO_1")]
        NomePerfilGPO1 = 10,

        [Description("QTD_MAX_DECIMAIS_GRANDEZA")]
        QuantidadeMaximaDecimaisGrandeza = 11,

        [Description("QTD_MAX_DIGITOS_GRANDEZA")]
        QuantidadeMaximaDigitosGrandeza = 12,

        [Description("QTD_MESES_A_FRENTE")]
        QuantidadeMesesAFrente = 13,

        [Description("MENSAGEM_INI_CONVERG_CCEE")]
        MensagemNotificacaoConvergenciaCcee = 14,

        [Description("ACRESCIMO_RESTRICAO_ELETRICA_TERMICA")]
        AcrescimoRestricaoEletricaTermica = 15
    }
}
