using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class DecisaoComandoGNL
{
    public int IdDecisaocomandognl { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdTppatamar { get; set; }

    public int IdTitulacao { get; set; }

    public double? ValDespacho { get; set; }

    public DateOnly DatInicial { get; set; }

    public DateOnly DatFinal { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual AuxUsinaMontador? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual Titulacao IdTitulacaoNavigation { get; set; } = null!;

    public virtual Patamar IdTppatamarNavigation { get; set; } = null!;
}
