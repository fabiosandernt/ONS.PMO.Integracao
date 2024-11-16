using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class LimitesIntercambio
{
    public int IdLimitesintercambio { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdInterligacao { get; set; }

    public string NomInterligacao { get; set; } = null!;

    public string NomDocumentoorigem { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public int NumOrdem { get; set; }

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual ICollection<LimitePeriodo> TbLimiteperiododia { get; set; } = new List<LimitePeriodo>();

    public virtual ICollection<LimitesPatamar> TbLimitespatamars { get; set; } = new List<LimitesPatamar>();

    public virtual ICollection<ReducaoLimiteIntercambio> TbReducaolimiteintercambios { get; set; } = new List<ReducaoLimiteIntercambio>();
}
