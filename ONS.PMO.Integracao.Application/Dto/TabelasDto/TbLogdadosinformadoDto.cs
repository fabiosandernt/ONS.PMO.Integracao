using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbLogdadosinformadoDto
{
    public int IdLogdadosinformados { get; set; }

    public int? IdAgenteInstituicao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public string? NomUsuario { get; set; }

    public string? MailUsuario { get; set; }

    public string? DscAcao { get; set; }

    public DateTime? DinAcao { get; set; }
}
