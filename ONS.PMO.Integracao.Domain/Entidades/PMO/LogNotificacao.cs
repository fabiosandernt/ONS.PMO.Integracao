using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class LogNotificacao
{
    public int IdLognotificacao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int IdAgenteInstituicao { get; set; }

    public string DscAcao { get; set; } = null!;

    public DateTime DinAcao { get; set; }

    public string MailEnviar { get; set; } = null!;

    public string? MailEnviado { get; set; }

    public string? NomUsuario { get; set; }

    public virtual AgenteInstituicao IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual SemanaOperativa IdSemanaoperativaNavigation { get; set; } = null!;
}
