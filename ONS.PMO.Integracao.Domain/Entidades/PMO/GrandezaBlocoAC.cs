using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class GrandezaBlocoAC
{
    public int IdGrandezamontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public virtual GrandezaMontador IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual MnemonicoBlocoAC IdMnemonicoblocoacNavigation { get; set; } = null!;

    public virtual ICollection<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudo>();

    public virtual ICollection<GrandezaBlocoAC> IdGrandezamontadordependentes { get; set; } = new List<GrandezaBlocoAC>();

    public virtual ICollection<GrandezaBlocoAC> IdGrandezamontadors { get; set; } = new List<GrandezaBlocoAC>();
}
