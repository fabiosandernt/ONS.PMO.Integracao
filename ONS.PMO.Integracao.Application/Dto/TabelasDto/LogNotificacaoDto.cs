using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class LogNotificacaoDto
{
    public int IdLognotificacao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int IdAgenteinstituicao { get; set; }

    public string DscAcao { get; set; } = null!;

    public DateTime DinAcao { get; set; }

    public string MailEnviar { get; set; } = null!;

    public string? MailEnviado { get; set; }

    public string? NomUsuario { get; set; }

    public virtual AgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual SemanaOperativaDto IdSemanaoperativaNavigation { get; set; } = null!;
}
