using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxContrato
{
    public int IdContrato { get; set; }

    public int CodContrato { get; set; }

    public string NomContrato { get; set; } = null!;

    public string? DscContrato { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string LgnUltimaalteracao { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public bool FlgAtivo { get; set; }

    public DateTime DinIniciovalidade { get; set; }

    public DateTime? DinTerminovalidade { get; set; }

    public virtual ICollection<AuxSubsistemaContrato> TbAuxSubsistemacontratos { get; set; } = new List<AuxSubsistemaContrato>();
}
