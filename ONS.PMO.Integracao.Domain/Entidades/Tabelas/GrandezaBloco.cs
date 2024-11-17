using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class GrandezaBloco
{
    public int IdGrandezamontador { get; set; }

    public int IdBloco { get; set; }

    public int? IdGrandeza { get; set; }

    public int? IdGrandezamontadorref { get; set; }

    public bool FlgColetapormeses { get; set; }

    public bool FlgColetaporsemanas { get; set; }

    public bool FlgQuebraestagio { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual Grandeza? IdGrandezaNavigation { get; set; }

    public virtual GrandezaMontador IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual GrandezaBloco? IdGrandezamontadorrefNavigation { get; set; }

    public virtual ICollection<GrandezaBloco> InverseIdGrandezamontadorrefNavigation { get; set; } = new List<GrandezaBloco>();

    public virtual ICollection<ColunaGrandeza> TbColunagrandezas { get; set; } = new List<ColunaGrandeza>();

    public virtual ICollection<OrdenacaoRegistro> TbOrdenacaoregistros { get; set; } = new List<OrdenacaoRegistro>();
}
