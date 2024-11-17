using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbManutencaoprogramadumDto
{
    public int IdManutencaoprogramada { get; set; }

    public int IdTpmanutencaoprogramada { get; set; }

    public int? IdOrigemuge { get; set; }

    public int? IdOrigemusi { get; set; }

    public int IdAgenteInstituicao { get; set; }

    public int IdEstudomontador { get; set; }

    public DateTime DinInicio { get; set; }

    public DateTime DinTermino { get; set; }

    public string DscJustificativa { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual TbAgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbAuxUnidadegeradoramontadorDto? IdOrigemugeNavigation { get; set; }

    public virtual TbAuxUsinamontadorDto? IdOrigemusiNavigation { get; set; }

    public virtual TbTpmanutencaoprogramadumDto IdTpmanutencaoprogramadaNavigation { get; set; } = null!;
}
