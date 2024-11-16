using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ExportacaoArquivoTexto
{
    public int IdExportacaoarquivotexto { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int? IdArquivoexportacao { get; set; }

    public string NomArquivotexto { get; set; } = null!;

    public string CodHash { get; set; } = null!;

    public DateTime DinExportacao { get; set; }

    public string LgnExportacao { get; set; } = null!;

    public virtual ArquivoExportacao? IdArquivoexportacaoNavigation { get; set; }

    public virtual SemanaOperativa IdSemanaoperativaNavigation { get; set; } = null!;
}
