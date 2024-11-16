using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class InsumoPMO
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

    public virtual ICollection<ColetaInsumo> TbColetainsumos { get; set; } = new List<ColetaInsumo>();

    public virtual ICollection<Gabarito> TbGabaritos { get; set; } = new List<Gabarito>();

    public virtual InsumoEstruturado? TbInsumoestruturado { get; set; }

    public virtual InsumoNaoEstruturado? TbInsumonaoestruturado { get; set; }
}
