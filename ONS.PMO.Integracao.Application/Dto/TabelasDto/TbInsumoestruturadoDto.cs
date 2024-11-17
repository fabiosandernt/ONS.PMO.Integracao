using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbInsumoestruturadoDto
{
    public int IdInsumopmo { get; set; }

    public int IdTpcategoriainsumo { get; set; }

    public int? IdTpcoleta { get; set; }

    public int? QtdMesesadiante { get; set; }

    public string? TipBlocomontador { get; set; }

    public int? NumOrdemblocomontador { get; set; }

    public virtual TbInsumopmoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual TbTpcategoriainsumoDto IdTpcategoriainsumoNavigation { get; set; } = null!;

    public virtual TbTpcoletumDto? IdTpcoletaNavigation { get; set; }

    public virtual ICollection<TbGrandezaDto> TbGrandezas { get; set; } = new List<TbGrandezaDto>();
}
