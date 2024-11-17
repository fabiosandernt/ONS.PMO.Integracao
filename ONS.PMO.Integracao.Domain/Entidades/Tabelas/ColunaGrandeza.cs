using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ColunaGrandeza
{
    public int IdColunagrandeza { get; set; }

    public int IdGrandezamontador { get; set; }

    public int? IdTppatamar { get; set; }

    public int? IdTplimite { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public virtual GrandezaBloco IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual Limite? IdTplimiteNavigation { get; set; }

    public virtual Patamar? IdTppatamarNavigation { get; set; }

    public virtual ICollection<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudo>();

    public virtual ICollection<ModificacaoConfiguracaoBlocoEstudo> IdModifconfigblocoestudos { get; set; } = new List<ModificacaoConfiguracaoBlocoEstudo>();
}
