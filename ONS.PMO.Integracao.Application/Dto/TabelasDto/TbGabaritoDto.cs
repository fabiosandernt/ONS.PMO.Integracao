using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGabaritoDto
{
    public int IdGabarito { get; set; }

    public int IdInsumopmo { get; set; }

    public bool FlgPadrao { get; set; }

    public string? CodPerfilons { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public string? IdOrigemcoleta { get; set; }

    public int? IdAgenteInstituicao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual TbAgenteinstituicaoDto? IdAgenteinstituicaoNavigation { get; set; }

    public virtual TbInsumopmoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual TbOrigemcoletumDto? IdOrigemcoletaNavigation { get; set; }

    public virtual TbSemanaoperativaDto? IdSemanaoperativaNavigation { get; set; }

    public virtual ICollection<TbDadocoletumDto> TbDadocoleta { get; set; } = new List<TbDadocoletumDto>();
}
