using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class AuxReeMontador
{
    public int IdOrigemcoletamontador { get; set; }

    public int CodRee { get; set; }

    public string NomCurtoree { get; set; } = null!;

    public string? NomLongoree { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
