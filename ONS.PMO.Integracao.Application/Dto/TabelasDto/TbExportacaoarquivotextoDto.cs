using ONS.PMO.Integracao.Application.Dto.PMO;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbExportacaoarquivotextoDto
{
    public int IdExportacaoarquivotexto { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int? IdArquivoexportacao { get; set; }

    public string NomArquivotexto { get; set; } = null!;

    public string CodHash { get; set; } = null!;

    public DateTime DinExportacao { get; set; }

    public string LgnExportacao { get; set; } = null!;

    public virtual TbArquivoexportacaoDto? IdArquivoexportacaoNavigationDto { get; set; }

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigationDto { get; set; } = null!;
}
