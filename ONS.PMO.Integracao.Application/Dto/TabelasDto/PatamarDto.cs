using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class PatamarDto
{
    public int IdTppatamar { get; set; }

    public string DscTppatamar { get; set; } = null!;

    public double? ValVermelho { get; set; }

    public double? ValVerde { get; set; }

    public double? ValAzul { get; set; }

    public virtual ICollection<ColunaGrandezaDto> TbColunagrandezas { get; set; } = new List<ColunaGrandezaDto>();

    public virtual ICollection<DadoColetaEstruturadoDto> TbDadocoletaestruturados { get; set; } = new List<DadoColetaEstruturadoDto>();

    public virtual ICollection<DecisaoComandoGNLDto> TbDecisaocomandognls { get; set; } = new List<DecisaoComandoGNLDto>();

    public virtual ICollection<GeracaoMinimaPeriodoDto> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodoDto>();

    public virtual ICollection<LimitePeriodoDto> TbLimiteperiododia { get; set; } = new List<LimitePeriodoDto>();

    public virtual ICollection<LimitesPatamarDto> TbLimitespatamars { get; set; } = new List<LimitesPatamarDto>();
}
