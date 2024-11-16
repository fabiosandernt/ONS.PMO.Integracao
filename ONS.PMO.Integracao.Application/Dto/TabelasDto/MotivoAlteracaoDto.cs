using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class MotivoAlteracaoDto
{
    public int IdMotivoalteracao { get; set; }

    public string? NomMotivo { get; set; }

    public string? DscMotivo { get; set; }

    public bool? FlgAtivo { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual ICollection<GrandezaMnemonicoEstudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudoDto>();
}
