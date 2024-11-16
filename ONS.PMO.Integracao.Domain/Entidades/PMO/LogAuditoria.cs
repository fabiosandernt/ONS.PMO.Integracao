using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class LogAuditoria
{
    public int IdLogauditoria { get; set; }

    public string NomRegistro { get; set; } = null!;

    public DateTime DinExecucao { get; set; }

    public string NomFuncionalidade { get; set; } = null!;

    public string NomExecutor { get; set; } = null!;

    public string DscTipoacaoexecutada { get; set; } = null!;

    public string DocOperacaologada { get; set; } = null!;
}
