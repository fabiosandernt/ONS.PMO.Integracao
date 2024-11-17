using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbConjuntogeracaominimaDto
{
    public int IdConjuntogeracaominima { get; set; }

    public int IdEstudomontador { get; set; }

    public string NomConjuntogeracaominima { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string LgnUltimaalteracao { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbDesligamentoDto> TbDesligamentos { get; set; } = new List<TbDesligamentoDto>();

    public virtual ICollection<TbGeracaominimaperiododiumDto> TbGeracaominimaperiododia { get; set; } = new List<TbGeracaominimaperiododiumDto>();

    public virtual ICollection<TbAuxUsinamontadorDto> IdOrigemcoletamontadors { get; set; } = new List<TbAuxUsinamontadorDto>();
}
