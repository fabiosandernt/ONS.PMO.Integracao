using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GabaritoDto
{
    public int IdGabarito { get; set; }

    public int IdInsumopmo { get; set; }

    public bool FlgPadrao { get; set; }

    public string? CodPerfilons { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public string? IdOrigemcoleta { get; set; }

    public int? IdAgenteinstituicao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual AgenteinstituicaoDto? IdAgenteinstituicaoNavigation { get; set; }

    public virtual InsumoPmoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual OrigemColetumDto? IdOrigemcoletaNavigation { get; set; }

    public virtual SemanaOperativaDto? IdSemanaoperativaNavigation { get; set; }

    public virtual ICollection<DadoColetumDto> TbDadocoleta { get; set; } = new List<DadoColetumDto>();
}
