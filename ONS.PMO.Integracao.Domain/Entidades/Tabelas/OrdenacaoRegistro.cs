using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class OrdenacaoRegistro
{
    public int IdOrdenacaoregistros { get; set; }

    public int IdBloco { get; set; }

    public int NumOrdenacao { get; set; }

    public int? IdCampochave { get; set; }

    public int? IdGrandezamontador { get; set; }

    public string FlgTpordenacao { get; set; } = null!;

    public int NumRevisao { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual CampoChave? IdCampochaveNavigation { get; set; }

    public virtual GrandezaBloco? IdGrandezamontadorNavigation { get; set; }
}
