using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class TipoImportacaoPmo
{
    public int IdTpimportacaopmo { get; set; }

    public string DscTpimportacaopmo { get; set; } = null!;

    public virtual ICollection<ImportacaoPmo> TbImportacaopmos { get; set; } = new List<ImportacaoPmo>();
}
