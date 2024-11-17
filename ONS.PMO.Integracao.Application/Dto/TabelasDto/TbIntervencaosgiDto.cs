using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbIntervencaosgiDto
{
    public int IdIntervencaosgi { get; set; }

    public long NumIntervencaosgi { get; set; }

    public DateTime? DinInicioefetivo { get; set; }

    public DateTime? DinFimprogramado { get; set; }

    public string? DscIntervencaosgi { get; set; }

    public string? NomStatus { get; set; }

    public string? NomTpintervencaosgi { get; set; }

    public string? NomEquipamentoprincipal { get; set; }

    public string? DscRecomendacao { get; set; }

    public string? IdOrigemcoletauge { get; set; }

    public int? IdAgenteInstituicao { get; set; }

    public string? NomAgente { get; set; }
}
