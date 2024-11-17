using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDadocoletumDto
{
    public int IdDadocoleta { get; set; }

    public string TipDadocoleta { get; set; } = null!;

    public int? IdGrandeza { get; set; }

    public int IdGabarito { get; set; }

    public int IdColetainsumo { get; set; }

    public virtual TbColetainsumoDto IdColetainsumoNavigation { get; set; } = null!;

    public virtual TbGabaritoDto IdGabaritoNavigation { get; set; } = null!;

    public virtual TbGrandezaDto? IdGrandezaNavigation { get; set; }

    public virtual TbDadocoletaestruturadoDto? TbDadocoletaestruturado { get; set; }

    public virtual TbDadocoletamanutencaoDto? TbDadocoletamanutencao { get; set; }

    public virtual TbDadocoletanaoestruturadoDto? TbDadocoletanaoestruturado { get; set; }
}
