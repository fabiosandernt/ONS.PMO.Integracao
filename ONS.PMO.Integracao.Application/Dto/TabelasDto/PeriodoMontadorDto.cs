using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class PeriodoMontadorDto
{
    public int IdTpperiodomontador { get; set; }

    public string NomTpperiodomontador { get; set; } = null!;

    public virtual ICollection<MnemonicoPmoDto> TbMnemonicopmos { get; set; } = new List<MnemonicoPmoDto>();
}
