using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxMnemonicomontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomMnemonico { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxUsinamnemonicoDto> TbAuxUsinamnemonicos { get; set; } = new List<TbAuxUsinamnemonicoDto>();
}
