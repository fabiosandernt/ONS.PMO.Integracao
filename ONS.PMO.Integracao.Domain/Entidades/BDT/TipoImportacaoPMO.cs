using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class TipoImportacaoPMO
{
    public int IdTpimportacaopmo { get; set; }

    public string DscTpimportacaopmo { get; set; } = null!;

    public virtual ICollection<ImportacaoPMO> TbImportacaopmos { get; set; } = new List<ImportacaoPMO>();
}
