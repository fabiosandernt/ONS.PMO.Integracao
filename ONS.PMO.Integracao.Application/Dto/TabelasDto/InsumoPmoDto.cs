using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class InsumoPmoDto
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

    public virtual ICollection<ColetaInsumoDto> TbColetainsumos { get; set; } = new List<ColetaInsumoDto>();

    public virtual ICollection<GabaritoDto> TbGabaritos { get; set; } = new List<GabaritoDto>();

    public virtual InsumoEstruturadoDto? TbInsumoestruturado { get; set; }

    public virtual InsumoNaoEstruturadoDto? TbInsumonaoestruturado { get; set; }
}
