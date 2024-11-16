using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ConjuntoGeracaoMinimaDto
{
    public int IdConjuntogeracaominima { get; set; }

    public int IdEstudomontador { get; set; }

    public string NomConjuntogeracaominima { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string LgnUltimaalteracao { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual ICollection<DesligamentoDto> TbDesligamentos { get; set; } = new List<DesligamentoDto>();

    public virtual ICollection<GeracaoMinimaPeriodoDto> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodoDto>();

    public virtual ICollection<AuxUsinaMontadorDto> IdOrigemcoletamontadors { get; set; } = new List<AuxUsinaMontadorDto>();
}
