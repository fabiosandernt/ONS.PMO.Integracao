using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadoColetaManutencao
{
    public int IdDadocoleta { get; set; }

    public string? IdOrigemcoletauge { get; set; }

    public DateTime DatInicio { get; set; }

    public DateTime DatFim { get; set; }

    public string? PrdTemporetorno { get; set; }

    public string? DscJustificativa { get; set; }

    public string? NumManutencao { get; set; }

    public string? NomSituacao { get; set; }

    public string? SglClassificacaotpeqpintervencao { get; set; }

    public string? SglPeriodicidadeintervencao { get; set; }

    public virtual DadoColeta IdDadocoletaNavigation { get; set; } = null!;

    public virtual TbAuxUnidadegeradora? IdOrigemcoletaugeNavigation { get; set; }
}
