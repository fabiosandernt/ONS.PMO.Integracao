﻿using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DadoColetaManutencaoDto
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

    public virtual DadoColetumDto IdDadocoletaNavigation { get; set; } = null!;

    public virtual AuxUnidadeGeradoraDto? IdOrigemcoletaugeNavigation { get; set; }
}
