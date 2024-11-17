using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class GrandezaMnemonicoEstudo
{
    public int IdGrandezamnemonicoestudo { get; set; }

    public int IdGrandezamontador { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdEstudomontador { get; set; }

    public string ValGrandezamnemonicoestudo { get; set; } = null!;

    public string? FlgFonte { get; set; }

    public int? IdMotivoalteracao { get; set; }

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual GrandezaBlocoAC IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual MotivoAlteracao? IdMotivoalteracaoNavigation { get; set; }

    public virtual OrigemColetaMontador? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual ICollection<EstagioGrandezaMnemonico> TbEstagiograndezamnemonicos { get; set; } = new List<EstagioGrandezaMnemonico>();
}
