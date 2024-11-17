using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class TipoPeriodoMontador
{
    public int IdTpperiodomontador { get; set; }

    public string NomTpperiodomontador { get; set; } = null!;

    public virtual ICollection<MnemonicoPmo> TbMnemonicopmos { get; set; } = new List<MnemonicoPmo>();
}
