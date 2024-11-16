using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class InsumoEstruturadoDto
{
    public int IdInsumopmo { get; set; }

    public int IdTpcategoriainsumo { get; set; }

    public int? IdTpcoleta { get; set; }

    public int? QtdMesesadiante { get; set; }

    public string? TipBlocomontador { get; set; }

    public int? NumOrdemblocomontador { get; set; }

    public virtual InsumoPmoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual CategoriaInsumoDto IdTpcategoriainsumoNavigation { get; set; } = null!;

    public virtual ColetumDto? IdTpcoletaNavigation { get; set; }

    public virtual ICollection<GrandezaDto> TbGrandezas { get; set; } = new List<GrandezaDto>();
}
