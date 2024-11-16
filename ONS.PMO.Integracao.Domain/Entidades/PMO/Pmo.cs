using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class Pmo
{
    public int IdPmo { get; set; }

    public int AnoReferencia { get; set; }

    public int MesReferencia { get; set; }

    public int? QtdMesesadiante { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual ICollection<SemanaOperativa> TbSemanaoperativas { get; set; } = new List<SemanaOperativa>();
}
