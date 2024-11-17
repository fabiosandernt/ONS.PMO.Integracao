using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxUsina
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public string CodTpgeracao { get; set; } = null!;

    public int CodDpp { get; set; }

    public string? NomLongo { get; set; }

    public string? NomCurto { get; set; }

    public string? CodSubmercado { get; set; }

    public virtual OrigemColetum IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxUnidadegeradora> TbAuxUnidadegeradoras { get; set; } = new List<TbAuxUnidadegeradora>();
}
