using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbLognotificacaoDto
{
    public int IdLognotificacao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int IdAgenteInstituicao { get; set; }

    public string DscAcao { get; set; } = null!;

    public DateTime DinAcao { get; set; }

    public string MailEnviar { get; set; } = null!;

    public string? MailEnviado { get; set; }

    public string? NomUsuario { get; set; }

    public virtual TbAgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigation { get; set; } = null!;
}
