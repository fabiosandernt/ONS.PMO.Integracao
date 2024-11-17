using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTppatamarDto
{
    public int IdTppatamar { get; set; }

    public string DscTppatamar { get; set; } = null!;

    public double? ValVermelho { get; set; }

    public double? ValVerde { get; set; }

    public double? ValAzul { get; set; }

    public virtual ICollection<TbColunagrandezaDto> TbColunagrandezas { get; set; } = new List<TbColunagrandezaDto>();

    public virtual ICollection<TbDadocoletaestruturadoDto> TbDadocoletaestruturados { get; set; } = new List<TbDadocoletaestruturadoDto>();

    public virtual ICollection<TbDecisaocomandognlDto> TbDecisaocomandognls { get; set; } = new List<TbDecisaocomandognlDto>();

    public virtual ICollection<TbGeracaominimaperiododiumDto> TbGeracaominimaperiododia { get; set; } = new List<TbGeracaominimaperiododiumDto>();

    public virtual ICollection<TbLimiteperiododiumDto> TbLimiteperiododia { get; set; } = new List<TbLimiteperiododiumDto>();

    public virtual ICollection<TbLimitespatamarDto> TbLimitespatamars { get; set; } = new List<TbLimitespatamarDto>();
}
