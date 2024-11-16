using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DadoColetumDto
{
    public int IdDadocoleta { get; set; }

    public string TipDadocoleta { get; set; } = null!;

    public int? IdGrandeza { get; set; }

    public int IdGabarito { get; set; }

    public int IdColetainsumo { get; set; }

    public virtual ColetaInsumoDto IdColetainsumoNavigation { get; set; } = null!;

    public virtual GabaritoDto IdGabaritoNavigation { get; set; } = null!;

    public virtual GrandezaDto? IdGrandezaNavigation { get; set; }

    public virtual DadoColetaEstruturadoDto? TbDadocoletaestruturado { get; set; }

    public virtual DadoColetaManutencaoDto? TbDadocoletamanutencao { get; set; }

    public virtual DadoColetanaoEstruturadoDto? TbDadocoletanaoestruturado { get; set; }
}
