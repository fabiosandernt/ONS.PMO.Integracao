using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class LogDadosInformado
{
    public int IdLogdadosinformados { get; set; }

    public int? IdAgenteinstituicao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public string? NomUsuario { get; set; }

    public string? MailUsuario { get; set; }

    public string? DscAcao { get; set; }

    public DateTime? DinAcao { get; set; }
}
