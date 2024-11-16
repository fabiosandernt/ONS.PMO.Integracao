using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ManutencaoProgramadaDto
{
    public int IdManutencaoprogramada { get; set; }

    public int IdTpmanutencaoprogramada { get; set; }

    public int? IdOrigemuge { get; set; }

    public int? IdOrigemusi { get; set; }

    public int IdAgenteinstituicao { get; set; }

    public int IdEstudomontador { get; set; }

    public DateTime DinInicio { get; set; }

    public DateTime DinTermino { get; set; }

    public string DscJustificativa { get; set; } = null!;

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual AgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual AuxUnidadeGeradoraMontadorDto? IdOrigemugeNavigation { get; set; }

    public virtual AuxUsinaMontadorDto? IdOrigemusiNavigation { get; set; }

    public virtual ManutencaoProgramadumDto IdTpmanutencaoprogramadaNavigation { get; set; } = null!;
}
