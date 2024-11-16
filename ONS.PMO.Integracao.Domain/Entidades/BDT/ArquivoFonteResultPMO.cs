using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class ArquivoFonteResultPMO
{
    public int IdArquivofonteresultpmo { get; set; }

    public string NomArquivofonteresultpmo { get; set; } = null!;

    public virtual ICollection<ResultadoColetaPMO> TbResultadocoletapmos { get; set; } = new List<ResultadoColetaPMO>();
}
