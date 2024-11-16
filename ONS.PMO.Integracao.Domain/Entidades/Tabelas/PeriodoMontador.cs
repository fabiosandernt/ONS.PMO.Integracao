using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class PeriodoMontador
{
    public int IdTpperiodomontador { get; set; }

    public string NomTpperiodomontador { get; set; } = null!;

    public virtual ICollection<MnemonicoPMO> TbMnemonicopmos { get; set; } = new List<MnemonicoPMO>();
}
