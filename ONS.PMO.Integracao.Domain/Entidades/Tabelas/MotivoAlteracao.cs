using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class MotivoAlteracao
{
    public int IdMotivoalteracao { get; set; }

    public string? NomMotivo { get; set; }

    public string? DscMotivo { get; set; }

    public bool? FlgAtivo { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual ICollection<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudo>();
}
