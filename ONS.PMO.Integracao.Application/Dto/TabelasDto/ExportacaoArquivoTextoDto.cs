namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ExportacaoArquivoTextoDto
{
    public int IdExportacaoarquivotexto { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int? IdArquivoexportacao { get; set; }

    public string NomArquivotexto { get; set; } = null!;

    public string CodHash { get; set; } = null!;

    public DateTime DinExportacao { get; set; }

    public string LgnExportacao { get; set; } = null!;

    public virtual ArquivoExportacaoDto? IdArquivoexportacaoNavigationDto { get; set; }

    public virtual SemanaOperativaDto IdSemanaoperativaNavigationDto { get; set; } = null!;
}
