using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGeracaotermicaDto
{
    public int IdGeracaotermicas { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string? NomCurtosubsistema { get; set; }

    public int NumEstagio { get; set; }

    public double? ValGeracaotermicas { get; set; }

    public string? NomCurtosubmercado { get; set; }

    public virtual TbConfiguracaogestaomanutencaoDto IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
