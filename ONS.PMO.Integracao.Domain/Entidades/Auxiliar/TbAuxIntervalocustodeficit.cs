using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxIntervalocustodeficit
{
    public int IdIntervalocustodeficit { get; set; }

    public int CodIntervalocustodeficit { get; set; }

    public string NomIntervalocustodeficit { get; set; } = null!;

    public string? DscIntervalocustodeficit { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string LgnUltimaalteracao { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public bool FlgAtivo { get; set; }

    public DateTime DinIniciovalidade { get; set; }

    public DateTime? DinTerminovalidade { get; set; }

    public virtual ICollection<TbAuxSubsistemaintervalocustodeficit> TbAuxSubsistemaintervalocustodeficits { get; set; } = new List<TbAuxSubsistemaintervalocustodeficit>();
}
