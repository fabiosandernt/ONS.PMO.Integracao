using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Patamar
{
    public int IdTppatamar { get; set; }

    public string DscTppatamar { get; set; } = null!;

    public double? ValVermelho { get; set; }

    public double? ValVerde { get; set; }

    public double? ValAzul { get; set; }

    public virtual ICollection<ColunaGrandeza> TbColunagrandezas { get; set; } = new List<ColunaGrandeza>();

    public virtual ICollection<DadoColetaEstruturado> TbDadocoletaestruturados { get; set; } = new List<DadoColetaEstruturado>();

    public virtual ICollection<DecisaoComandoGNL> TbDecisaocomandognls { get; set; } = new List<DecisaoComandoGNL>();

    public virtual ICollection<GeracaoMinimaPeriodo> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodo>();

    public virtual ICollection<LimitePeriodo> TbLimiteperiododia { get; set; } = new List<LimitePeriodo>();

    public virtual ICollection<LimitesPatamar> TbLimitespatamars { get; set; } = new List<LimitesPatamar>();
}
