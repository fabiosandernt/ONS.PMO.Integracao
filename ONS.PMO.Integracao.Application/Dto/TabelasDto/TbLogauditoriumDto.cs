using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbLogauditoriumDto
{
    public int IdLogauditoria { get; set; }

    public string NomRegistro { get; set; } = null!;

    public DateTime DinExecucao { get; set; }

    public string NomFuncionalidade { get; set; } = null!;

    public string NomExecutor { get; set; } = null!;

    public string DscTipoacaoexecutada { get; set; } = null!;

    public string DocOperacaologada { get; set; } = null!;
}
