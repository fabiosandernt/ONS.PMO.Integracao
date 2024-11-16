using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class LogDadosInformadoDto
{
    public int IdLogdadosinformados { get; set; }

    public int? IdAgenteinstituicao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public string? NomUsuario { get; set; }

    public string? MailUsuario { get; set; }

    public string? DscAcao { get; set; }

    public DateTime? DinAcao { get; set; }
}
