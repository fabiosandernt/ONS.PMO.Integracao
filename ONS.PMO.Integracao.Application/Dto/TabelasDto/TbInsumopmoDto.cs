using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbInsumopmoDto
{
    public int IdInsumopmo { get; set; }

    public string TipInsumopmo { get; set; } = null!;

    public string NomInsumopmo { get; set; } = null!;

    public short NumOrdemexibicao { get; set; }

    public bool FlgPreaprovado { get; set; }

    public bool FlgReservado { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }

    public bool FlgExportainsumo { get; set; }

    public string SglInsumo { get; set; } = null!;

    public bool FlgAtivo { get; set; }

    public virtual ICollection<TbColetainsumoDto> TbColetainsumos { get; set; } = new List<TbColetainsumoDto>();

    public virtual ICollection<TbGabaritoDto> TbGabaritos { get; set; } = new List<TbGabaritoDto>();

    public virtual TbInsumoestruturadoDto? TbInsumoestruturado { get; set; }

    public virtual TbInsumonaoestruturadoDto? TbInsumonaoestruturado { get; set; }
}
