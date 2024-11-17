using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxSubsistemamontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int CodSubsistema { get; set; }

    public int? NumTppatamares { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxPequenausina> TbAuxPequenausinas { get; set; } = new List<TbAuxPequenausina>();

    public virtual ICollection<TbAuxSubsistemacontrato> TbAuxSubsistemacontratos { get; set; } = new List<TbAuxSubsistemacontrato>();

    public virtual ICollection<TbAuxSubsistemaintervalocustodeficit> TbAuxSubsistemaintervalocustodeficits { get; set; } = new List<TbAuxSubsistemaintervalocustodeficit>();
}
