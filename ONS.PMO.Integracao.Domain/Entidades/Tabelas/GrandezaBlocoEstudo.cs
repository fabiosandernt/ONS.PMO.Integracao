using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class GrandezaBlocoEstudo
{
    public int IdGrandezablocoestudo { get; set; }

    public int IdColunagrandeza { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdRestricao { get; set; }

    public string ValGrandezablocoestudo { get; set; } = null!;

    public string? FlgFonte { get; set; }

    public bool? FlgNormalizado { get; set; }

    public string? ValGrandezablocoestudooriginal { get; set; }

    public virtual ColunaGrandeza IdColunagrandezaNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual Restricao? IdRestricaoNavigation { get; set; }

    public virtual ICollection<EstagioGrandeza> TbEstagiograndezas { get; set; } = new List<EstagioGrandeza>();
}
